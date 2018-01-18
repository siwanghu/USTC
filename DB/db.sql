-- MySQL dump 10.13  Distrib 5.7.20, for Linux (x86_64)
--
-- Host: localhost    Database: DB
-- ------------------------------------------------------
-- Server version	5.7.20-0ubuntu0.16.04.1

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Dumping data for table `cars`
--

LOCK TABLES `cars` WRITE;
/*!40000 ALTER TABLE `cars` DISABLE KEYS */;
INSERT INTO `cars` VALUES ('C1','nanjing',100,10,1),('C10','haerbing',100,10,10),('C2','shanghai',100,10,2),('C3','hanzhou',100,10,3),('C4','beijing',100,10,3),('C5','wuhang',100,10,5),('C6','tianjing',100,10,6),('C7','hefei',100,10,7),('C8','shengyang',100,10,8),('C9','changchun',100,10,9);
/*!40000 ALTER TABLE `cars` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` VALUES ('P1'),('p10'),('p11'),('P2'),('p3'),('p4'),('p5'),('p6'),('p7'),('p8'),('p9');
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `flights`
--

LOCK TABLES `flights` WRITE;
/*!40000 ALTER TABLE `flights` DISABLE KEYS */;
INSERT INTO `flights` VALUES ('A1',100,30,1,'nanjing','shanghai'),('A10',1000,30,4,'nanjing','haerbing'),('A2',200,30,2,'nanjing','beijing'),('A3',300,30,3,'nanjing','wuhang'),('A4',400,30,4,'nanjing','hanzhou'),('A5',500,30,5,'nanjing','guangzhou'),('A6',600,30,6,'nanjing','hefei'),('A7',700,30,7,'nanjing','tianjing'),('A8',800,30,8,'nanjing','shengyang'),('A9',900,30,3,'nanjing','changchun');
/*!40000 ALTER TABLE `flights` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `hotels`
--

LOCK TABLES `hotels` WRITE;
/*!40000 ALTER TABLE `hotels` DISABLE KEYS */;
INSERT INTO `hotels` VALUES ('H1','nanjing',100,10,1),('H10','haerbing',100,10,6),('H2','shanghai',100,10,2),('H3','hanzhou',100,10,3),('H4','beijing',100,10,0),('H5','wuhang',100,10,5),('H6','tianjing',100,10,6),('H7','hefei',100,10,7),('H8','shengyang',100,10,8),('H9','changchun',100,10,9);
/*!40000 ALTER TABLE `hotels` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `reservations`
--

LOCK TABLES `reservations` WRITE;
/*!40000 ALTER TABLE `reservations` DISABLE KEYS */;
INSERT INTO `reservations` VALUES ('p1','H10','C4'),('p10','H10','C10'),('p2','H2','C2'),('p3','H3','C3'),('p4','H4','C4'),('p5','H5','C5'),('p6','H6','C6'),('p7','H7','C7'),('p8','H8','C8'),('p9','H9','C9');
/*!40000 ALTER TABLE `reservations` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-01-18 18:29:16
