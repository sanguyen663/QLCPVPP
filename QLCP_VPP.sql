-- MySQL dump 10.16  Distrib 10.1.48-MariaDB, for debian-linux-gnu (x86_64)
--
-- Host: localhost    Database: db
-- ------------------------------------------------------
-- Server version	10.1.48-MariaDB-0+deb9u2

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `dbo.BANBAODAM`
--

DROP TABLE IF EXISTS `dbo.BANBAODAM`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.BANBAODAM` (
  `MA_BAN` varchar(0) DEFAULT NULL,
  `TENVP` varchar(0) DEFAULT NULL,
  `DIACHI` varchar(0) DEFAULT NULL,
  `SDT` varchar(0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.BANBAODAM`
--

LOCK TABLES `dbo.BANBAODAM` WRITE;
/*!40000 ALTER TABLE `dbo.BANBAODAM` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.BANBAODAM` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.CANBO`
--

DROP TABLE IF EXISTS `dbo.CANBO`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.CANBO` (
  `MA_CANBO` varchar(0) DEFAULT NULL,
  `TEN_CANBO` varchar(0) DEFAULT NULL,
  `NGAYSINH` varchar(0) DEFAULT NULL,
  `GIOITINH` varchar(0) DEFAULT NULL,
  `CHUCVU` varchar(0) DEFAULT NULL,
  `SDT` varchar(0) DEFAULT NULL,
  `MA_DONVI` varchar(0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.CANBO`
--

LOCK TABLES `dbo.CANBO` WRITE;
/*!40000 ALTER TABLE `dbo.CANBO` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.CANBO` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.CT_PHIEUDOITRA`
--

DROP TABLE IF EXISTS `dbo.CT_PHIEUDOITRA`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.CT_PHIEUDOITRA` (
  `MA_PHIEU` varchar(0) DEFAULT NULL,
  `MA_VPP` varchar(0) DEFAULT NULL,
  `SOLUONG` varchar(0) DEFAULT NULL,
  `NGAY_DOITRA` varchar(0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.CT_PHIEUDOITRA`
--

LOCK TABLES `dbo.CT_PHIEUDOITRA` WRITE;
/*!40000 ALTER TABLE `dbo.CT_PHIEUDOITRA` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.CT_PHIEUDOITRA` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.CT_PH_CP_VPP`
--

DROP TABLE IF EXISTS `dbo.CT_PH_CP_VPP`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.CT_PH_CP_VPP` (
  `MA_VPP` varchar(0) DEFAULT NULL,
  `MA_PH_CP` varchar(0) DEFAULT NULL,
  `SOLUONG` varchar(0) DEFAULT NULL,
  `NGAY_CP` varchar(0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.CT_PH_CP_VPP`
--

LOCK TABLES `dbo.CT_PH_CP_VPP` WRITE;
/*!40000 ALTER TABLE `dbo.CT_PH_CP_VPP` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.CT_PH_CP_VPP` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.CT_PH_NHAP_VPP`
--

DROP TABLE IF EXISTS `dbo.CT_PH_NHAP_VPP`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.CT_PH_NHAP_VPP` (
  `MA_VPP` varchar(0) DEFAULT NULL,
  `MA_PH_NHAP` varchar(0) DEFAULT NULL,
  `SOLUONG` varchar(0) DEFAULT NULL,
  `NGAY_NHAP` varchar(0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.CT_PH_NHAP_VPP`
--

LOCK TABLES `dbo.CT_PH_NHAP_VPP` WRITE;
/*!40000 ALTER TABLE `dbo.CT_PH_NHAP_VPP` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.CT_PH_NHAP_VPP` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.DONVI`
--

DROP TABLE IF EXISTS `dbo.DONVI`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.DONVI` (
  `MA_DONVI` varchar(0) DEFAULT NULL,
  `TEN_DONVI` varchar(0) DEFAULT NULL,
  `SOLUONG_HV` varchar(0) DEFAULT NULL,
  `SDT` varchar(0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.DONVI`
--

LOCK TABLES `dbo.DONVI` WRITE;
/*!40000 ALTER TABLE `dbo.DONVI` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.DONVI` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.LOAIVPP`
--

DROP TABLE IF EXISTS `dbo.LOAIVPP`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.LOAIVPP` (
  `MA_LOAI_VPP` varchar(0) DEFAULT NULL,
  `TENLOAI_VPP` varchar(0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.LOAIVPP`
--

LOCK TABLES `dbo.LOAIVPP` WRITE;
/*!40000 ALTER TABLE `dbo.LOAIVPP` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.LOAIVPP` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.NHACUNGCAP`
--

DROP TABLE IF EXISTS `dbo.NHACUNGCAP`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.NHACUNGCAP` (
  `MA_NCC` varchar(0) DEFAULT NULL,
  `TEN_NCC` varchar(0) DEFAULT NULL,
  `DIACHI` varchar(0) DEFAULT NULL,
  `SDT` varchar(0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.NHACUNGCAP`
--

LOCK TABLES `dbo.NHACUNGCAP` WRITE;
/*!40000 ALTER TABLE `dbo.NHACUNGCAP` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.NHACUNGCAP` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.NHANVIEN`
--

DROP TABLE IF EXISTS `dbo.NHANVIEN`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.NHANVIEN` (
  `MANV` varchar(0) DEFAULT NULL,
  `TENNV` varchar(0) DEFAULT NULL,
  `GIOITINH` varchar(0) DEFAULT NULL,
  `SDT` varchar(0) DEFAULT NULL,
  `MA_BAN` varchar(0) DEFAULT NULL,
  `MA_TRP` varchar(0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.NHANVIEN`
--

LOCK TABLES `dbo.NHANVIEN` WRITE;
/*!40000 ALTER TABLE `dbo.NHANVIEN` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.NHANVIEN` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.PHIEUCAPPHAT_VPP`
--

DROP TABLE IF EXISTS `dbo.PHIEUCAPPHAT_VPP`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.PHIEUCAPPHAT_VPP` (
  `MA_PH_CP` varchar(0) DEFAULT NULL,
  `TEN_PH_CP` varchar(0) DEFAULT NULL,
  `MANV` varchar(0) DEFAULT NULL,
  `MA_DONVI` varchar(0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.PHIEUCAPPHAT_VPP`
--

LOCK TABLES `dbo.PHIEUCAPPHAT_VPP` WRITE;
/*!40000 ALTER TABLE `dbo.PHIEUCAPPHAT_VPP` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.PHIEUCAPPHAT_VPP` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.PHIEUDOITRA`
--

DROP TABLE IF EXISTS `dbo.PHIEUDOITRA`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.PHIEUDOITRA` (
  `MA_PHIEU` varchar(0) DEFAULT NULL,
  `TEN_PHIEU` varchar(0) DEFAULT NULL,
  `MANV` varchar(0) DEFAULT NULL,
  `MA_NCC` varchar(0) DEFAULT NULL,
  `MA_DONVI` varchar(0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.PHIEUDOITRA`
--

LOCK TABLES `dbo.PHIEUDOITRA` WRITE;
/*!40000 ALTER TABLE `dbo.PHIEUDOITRA` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.PHIEUDOITRA` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.PHIEUNHAP_VPP`
--

DROP TABLE IF EXISTS `dbo.PHIEUNHAP_VPP`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.PHIEUNHAP_VPP` (
  `MA_PH_NHAP` varchar(0) DEFAULT NULL,
  `TEN_PH_NHAP` varchar(0) DEFAULT NULL,
  `MANV` varchar(0) DEFAULT NULL,
  `MA_NCC` varchar(0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.PHIEUNHAP_VPP`
--

LOCK TABLES `dbo.PHIEUNHAP_VPP` WRITE;
/*!40000 ALTER TABLE `dbo.PHIEUNHAP_VPP` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.PHIEUNHAP_VPP` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.VANPHONGPHAM`
--

DROP TABLE IF EXISTS `dbo.VANPHONGPHAM`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.VANPHONGPHAM` (
  `MA_VPP` varchar(0) DEFAULT NULL,
  `TEN_VPP` varchar(0) DEFAULT NULL,
  `SOLUONG` varchar(0) DEFAULT NULL,
  `MA_NCC` varchar(0) DEFAULT NULL,
  `MA_BAN` varchar(0) DEFAULT NULL,
  `MA_LOAI_VPP` varchar(0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.VANPHONGPHAM`
--

LOCK TABLES `dbo.VANPHONGPHAM` WRITE;
/*!40000 ALTER TABLE `dbo.VANPHONGPHAM` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.VANPHONGPHAM` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-04-30 16:42:46
