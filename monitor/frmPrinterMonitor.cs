using SnmpSharpNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monitor
{
    public partial class frmPrinterMonitor : Form
    {
        public frmPrinterMonitor()
        {
            InitializeComponent();
        }

        private void frmPrinterMonitor_Load(object sender, EventArgs e)
        { 
            DataGridViewProgressColumn col = new DataGridViewProgressColumn();
            col.Name = "dev_printer_status";
            dataGridView_printer.DataSource = Common.dt_printer;
            dataGridView_printer.Columns.Add(col);
            Thread.Sleep(500);
            StartPrinterThreads();
        }
        public void destorythread()
        {
            //终止线程
            canceltokensource.Cancel();
        }
        private void StartPrinterThreads()
        {
            try
            {
                int MaxPrinterDev = Common.dt_printer.Rows.Count;//线程数

                for (int i = 0; i < MaxPrinterDev; i++)
                {
                    string id = dataGridView_printer.Rows[i].Cells["Id"].Value.ToString();
                    CreatePrinterThreads(id);//遍历表格，创建线程
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("遇到错误，请重试!{0}", e.Message), "错误"
                    , MessageBoxButtons.OK);
            }
        }

        CancellationTokenSource canceltokensource = new CancellationTokenSource();
        private void CreatePrinterThreads(object id)
        {
            ThreadPool.QueueUserWorkItem(GetPrinterResponse, id);
        }
        private void show_data(string id,int data)
        {
            for (int i=0;i<dataGridView_printer.Rows.Count;i++) {
                if (dataGridView_printer.Rows[i].Cells["Id"].Value.ToString()==id) {
                    dataGridView_printer.Rows[i].Cells["dev_printer_status"].Value = data;
                }
            }
        }//将对应id的条目的值设置为data
 

        private void GetPrinterResponse(object input_id)
        {
            string id = input_id.ToString();
            string ipaddr = null;
            for (int i = 0; i < Common.dt_printer.Rows.Count; i++)
            {
                string tmp = Common.dt_printer.Rows[i]["Id"].ToString();
                if (tmp == (string)id)
                {
                    ipaddr = Common.dt_printer.Rows[i]["dev_ip"].ToString();
                }
            }
            int feq = Common.getfequency((string)id);
            OctetString community = new OctetString("public");
            AgentParameters param = new AgentParameters(community);
            param.Version = SnmpVersion.Ver1;
            IpAddress agent = new IpAddress(ipaddr);
            UdpTarget target = new UdpTarget((IPAddress)agent, 161, 2000, 1);
            Pdu pdu = new Pdu(PduType.Get);
            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.9.1.1");
            for (; ; )
            {
                if (canceltokensource.IsCancellationRequested == true)
                {
                    Common.writetologfrm(string.Format("打印机 设备ID:{1} 线程{0}终止", Thread.CurrentThread.ManagedThreadId, id.ToString()));
                    target.Dispose();
                    this.Close();
                    break;//若收到cancellationToken消息则取消此线程
                }
                try
                {
                    SnmpV1Packet result = (SnmpV1Packet)target.Request(pdu, param);
                    if (result != null)
                    {
                        if (result.Pdu.ErrorStatus != 0)
                        {
                            Common.writetologfrm(string.Format("打印机 ID:{0} 获取信息异常码{1}在{2}上", (string)id,result.Pdu.ErrorStatus,result.Pdu.ErrorIndex));
                        }
                        else
                        {
                            int i = Convert.ToInt32(result.Pdu.VbList[0].Value.ToString());

                            this.Invoke(new MethodInvoker(() => { show_data(id, i); }));
                        }
                    }
                    else
                    {
                        Common.writetologfrm(string.Format("打印机 ID:{0} 未收到回复",(string)id));
                    }
                }
                catch {
                    Common.writetologfrm(string.Format("打印机 ID:{0} 获取信息异常",(string)id));
                }
                Thread.Sleep(Common.getfequency((string)id));
            }
            //target.Dispose();
        }//Printer线程工作内容


        protected override void WndProc(ref Message msg)
        {
            const int CMD = 0x0112;
            const int CLOSE = 0xF060;
            if (msg.Msg == CMD && (int)msg.WParam == CLOSE)
            {
                this.Hide();
            }
            base.WndProc(ref msg);
        }//重写窗体关闭事件

        //重绘columns
        public class DataGridViewProgressColumn : DataGridViewImageColumn
        {
            public DataGridViewProgressColumn()
            {
                CellTemplate = new DataGridViewProgressCell();
            }
            class DataGridViewProgressCell : DataGridViewImageCell
            {
                // Used to make custom cell consistent with a DataGridViewImageCell
                static Image emptyImage;
                static DataGridViewProgressCell()
                {
                    emptyImage = new Bitmap(1, 1, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                }
                public DataGridViewProgressCell()
                {
                    this.ValueType = typeof(int);
                }
                // Method required to make the Progress Cell consistent with the default Image Cell. 
                // The default Image Cell assumes an Image as a value, although the value of the Progress Cell is an int.
                protected override object GetFormattedValue(object value,
                                    int rowIndex, ref DataGridViewCellStyle cellStyle,
                                    TypeConverter valueTypeConverter,
                                    TypeConverter formattedValueTypeConverter,
                                    DataGridViewDataErrorContexts context)
                {
                    return emptyImage;
                }
                protected override void Paint(System.Drawing.Graphics g, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
                {
                    int progressVal;
                    if (value != null)
                        progressVal = (int)value;
                    else
                        progressVal = 0;
                    float percentage = ((float)progressVal / 100.0f); // Need to convert to float before division; otherwise C# returns int which is 0 for anything but 100%.
                    Brush backColorBrush = new SolidBrush(cellStyle.BackColor);
                    Brush foreColorBrush = new SolidBrush(cellStyle.ForeColor);
                    // Draws the cell grid
                    base.Paint(g, clipBounds, cellBounds,
                     rowIndex, cellState, value, formattedValue, errorText,
                     cellStyle, advancedBorderStyle, (paintParts & ~DataGridViewPaintParts.ContentForeground));
                    if (percentage > 0.0 || percentage - 0.0 < float.Epsilon)
                    {
                        // Draw the progress bar and the text
                        g.FillRectangle(new SolidBrush(Color.FromArgb(163, 189, 242)), cellBounds.X + 2, cellBounds.Y + 2, Convert.ToInt32((percentage * cellBounds.Width - 4)), cellBounds.Height - 4);
                        g.DrawString(progressVal.ToString() + "%", cellStyle.Font, foreColorBrush, cellBounds.X + 6, cellBounds.Y + 2);
                    }
                    else
                    {
                        // draw the text
                        if (this.DataGridView.CurrentRow.Index == rowIndex)
                            g.DrawString(progressVal.ToString() + "%", cellStyle.Font, new SolidBrush(cellStyle.SelectionForeColor), cellBounds.X + 6, cellBounds.Y + 2);
                        else
                            g.DrawString(progressVal.ToString() + "%", cellStyle.Font, foreColorBrush, cellBounds.X + 6, cellBounds.Y + 2);
                    }
                }
            }
        }

        private void dataGridView_printer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
