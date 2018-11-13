# Host: localhost  (Version: 5.5.53)
# Date: 2018-11-13 15:13:02
# Generator: MySQL-Front 5.3  (Build 4.234)

/*!40101 SET NAMES utf8 */;

#
# Structure for table "log_icmp"
#

DROP TABLE IF EXISTS `log_icmp`;
CREATE TABLE `log_icmp` (
  `Id` bigint(20) NOT NULL AUTO_INCREMENT,
  `dev_id` varchar(20) DEFAULT NULL,
  `details` varchar(40) DEFAULT NULL,
  `timestamp` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

#
# Data for table "log_icmp"
#

/*!40000 ALTER TABLE `log_icmp` DISABLE KEYS */;
INSERT INTO `log_icmp` VALUES (1,'00000001','NULL','NULL'),(2,'2018228160','设备检测到离线','时间戳:10:40:15'),(3,'20181023153','设备检测到离线','14:46:28'),(4,'20181023153','设备检测到离线','14:31:43');
/*!40000 ALTER TABLE `log_icmp` ENABLE KEYS */;

#
# Structure for table "log_snmp"
#

DROP TABLE IF EXISTS `log_snmp`;
CREATE TABLE `log_snmp` (
  `Id` bigint(20) NOT NULL AUTO_INCREMENT,
  `dev_id` varchar(20) DEFAULT NULL,
  `details` varchar(40) DEFAULT NULL,
  `timestamp` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

#
# Data for table "log_snmp"
#

/*!40000 ALTER TABLE `log_snmp` DISABLE KEYS */;
INSERT INTO `log_snmp` VALUES (1,'00000001','NULL','NULL');
/*!40000 ALTER TABLE `log_snmp` ENABLE KEYS */;

#
# Structure for table "main_table"
#

DROP TABLE IF EXISTS `main_table`;
CREATE TABLE `main_table` (
  `Id` varchar(11) NOT NULL DEFAULT '',
  `dev_name` varchar(50) DEFAULT NULL,
  `dev_type` varchar(20) DEFAULT NULL,
  `dev_monitor_mode` varchar(15) DEFAULT NULL,
  `dev_ip` varchar(15) DEFAULT NULL,
  `dev_mac` varchar(17) DEFAULT NULL,
  `dev_extinfo` varchar(255) DEFAULT NULL,
  `dev_feq` int(11) unsigned DEFAULT NULL,
  `dev_icmp_status` int(11) DEFAULT NULL,
  `dev_snmp_status` int(11) DEFAULT NULL
) ENGINE=MyISAM AUTO_INCREMENT=2018881540 DEFAULT CHARSET=utf8;

#
# Data for table "main_table"
#

/*!40000 ALTER TABLE `main_table` DISABLE KEYS */;
INSERT INTO `main_table` VALUES ('2018918148','Localhost','Windows服务器','SNMP','172.16.139.68','NULL',NULL,12,NULL,NULL),('2018271438','My Desktop','Windows服务器','ICMP','172.16.160.169','23:bc:a2:c1:cc:4d','',12,NULL,NULL),('20181025133','北分','网络设备终端','Printer','172.16.203.113','NULL',NULL,12,NULL,NULL),('20181025133','342','UnixLinux服务器','SNMP','172.16.203.113','NULL',NULL,12,NULL,NULL),('20181181719','J3-4F-259','网络设备终端','Printer','172.16.203.176','NULL',NULL,6,NULL,NULL),('20189101213','客发运营办公室','网络设备终端','Printer','172.16.202.50','NULL',NULL,12,NULL,NULL),('2018918149','localhost','UnixLinux服务器','ICMP','172.16.139.68','NULL',NULL,12,NULL,NULL),('20181023153','不存在的点1','UnixLinux服务器','ICMP','172.16.111.111','NULL',NULL,12,NULL,NULL),('20181023153','不存在的点2','UnixLinux服务器','SNMP','172.16.111.112','NULL',NULL,12,NULL,NULL),('20181023154','TMI printer','UnixLinux服务器','Printer','172.16.203.144','NULL',NULL,12,NULL,NULL);
/*!40000 ALTER TABLE `main_table` ENABLE KEYS */;

#
# Structure for table "settings_miblib"
#

DROP TABLE IF EXISTS `settings_miblib`;
CREATE TABLE `settings_miblib` (
  `Id` int(11) NOT NULL DEFAULT '0',
  `sys_service` varchar(20) DEFAULT NULL,
  `sys_mib` varchar(50) NOT NULL DEFAULT '',
  `sys_items_enabled` int(1) NOT NULL DEFAULT '0',
  `sys_windows_enabled` int(2) NOT NULL DEFAULT '0',
  `sys_linux_enabled` int(2) NOT NULL DEFAULT '0',
  `sys_common_enabled` int(2) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=56 DEFAULT CHARSET=utf8;

#
# Data for table "settings_miblib"
#

/*!40000 ALTER TABLE `settings_miblib` DISABLE KEYS */;
INSERT INTO `settings_miblib` VALUES (1,'机器名','1.3.6.1.2.1.1.5',1,1,1,0),(2,'获取系统基本信息','1.3.6.1.2.1.1.1',1,1,1,0),(3,'系统运行时间','1.3.6.1.2.1.25.1.1',1,1,0,0),(4,'系统当前时间','1.3.6.1.2.1.25.1.2',1,1,0,0),(5,'系统物理内存','1.3.6.1.2.1.25.2.2',1,1,0,0),(6,'cpu占用率','1.3.6.1.2.1.25.3.3.1.2',1,1,0,0),(7,'系统进程数','1.3.6.1.2.1.25.1.6',1,1,1,0),(8,'系统进程','1.3.6.1.2.1.25.4.2.1.2',1,1,1,0),(9,'系统安装的软件','1.3.6.1.2.1.25.6.3.1.2',1,1,1,0),(10,'主机会话数','1.3.6.1.2.1.25.1.5',1,1,0,0),(11,'系统报错的总数','1.3.6.1.4.1.77.1.2.11',1,1,0,0),(12,'支持的并发数','1.3.6.1.4.1.77.1.2.16',1,1,0,0),(13,'用户帐号','1.3.6.1.4.1.77.1.2.25.1.1',1,1,0,0),(14,'启动的会话数','1.3.6.1.4.1.77.1.3.1',1,1,0,0),(15,'经历的失败会话数量','1.3.6.1.4.1.77.1.3.2',1,1,0,0),(16,'网络服务数目','1.3.6.1.4.1.77.1.2.2',1,1,0,0),(31,'时间段内负载','1.3.6.1.4.1.2021.10.1.3',1,0,1,0),(32,'系统服务','1.3.6.1.2.1.1.7',1,1,0,0),(33,'系统运行时间','1.3.6.1.2.1.1.3',1,1,1,0),(34,'系统CPU百分比','1.3.6.1.4.1.2021.11.10',1,0,1,0),(35,'用户CPU百分比','1.3.6.1.4.1.2021.11.9',1,0,1,0),(36,'CPU空闲时间比','1.3.6.1.4.1.2021.11.11',1,0,1,0),(37,'总使用内存','1.3.6.1.4.1.2021.4.6',1,0,1,0),(38,'总空闲内存','1.3.6.1.4.1.2021.4.11',1,0,1,0),(39,'总Cached内存','1.3.6.1.4.1.2021.4.15',1,0,1,0),(40,'总Buffered内存','1.3.6.1.4.1.2021.4.14',1,0,1,0),(41,'硬盘使用百分比','1.3.6.1.4.1.2021.9.1.9',1,0,1,0),(42,'硬盘可用空间','1.3.6.1.4.1.2021.9.1.7',1,0,1,0),(43,'inode使用百分比','1.3.6.1.4.1.2021.9.1.10',1,0,1,0),(44,'硬盘分区大小','1.3.6.1.4.1.2021.9.1.6',1,0,1,0),(45,'网络接口信息描述','1.3.6.1.2.1.2.2.1.2',1,0,1,0),(46,'网络接口类型','1.3.6.1.2.1.2.2.1.3',1,0,1,0),(47,'接口当前状态','1.3.6.1.2.1.2.2.1.8',1,0,1,0),(48,'接口收到的数据包个数','1.3.6.1.2.1.2.2.1.11',1,0,1,0),(49,'接口发送的数据包个数','1.3.6.1.2.1.2.2.1.17',1,0,1,0),(50,'丢弃接收包数','1.3.6.1.2.1.2.2.1.13',1,0,1,0),(51,'接收出错包数','1.3.6.1.2.1.2.2.1.14',1,0,1,0),(52,'丢弃发送包数','1.3.6.1.2.1.2.2.1.19',1,0,1,0),(53,'发送出错数','1.3.6.1.2.1.2.2.1.20',1,0,1,0),(54,'TCP主动连接总数','1.3.6.1.2.1.6.5',1,0,1,0),(55,'TCP被动连接总数','1.3.6.1.2.1.6.6',1,0,1,0),(60,'HP打印机剩余量','1.3.6.1.2.1.43.11.1.1.9.1',1,0,0,0);
/*!40000 ALTER TABLE `settings_miblib` ENABLE KEYS */;

#
# Structure for table "settings_monitorway"
#

DROP TABLE IF EXISTS `settings_monitorway`;
CREATE TABLE `settings_monitorway` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `sys_mode` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

#
# Data for table "settings_monitorway"
#

/*!40000 ALTER TABLE `settings_monitorway` DISABLE KEYS */;
INSERT INTO `settings_monitorway` VALUES (1,'SNMP'),(2,'ICMP'),(3,'Printer');
/*!40000 ALTER TABLE `settings_monitorway` ENABLE KEYS */;

#
# Structure for table "settings_servertype"
#

DROP TABLE IF EXISTS `settings_servertype`;
CREATE TABLE `settings_servertype` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `server_types` varchar(255) DEFAULT NULL,
  `server_short_name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

#
# Data for table "settings_servertype"
#

/*!40000 ALTER TABLE `settings_servertype` DISABLE KEYS */;
INSERT INTO `settings_servertype` VALUES (1,'Unix\\Linux服务器','type_linux'),(2,'Windows服务器','type_windows'),(3,'网络设备\\终端','type_common');
/*!40000 ALTER TABLE `settings_servertype` ENABLE KEYS */;
