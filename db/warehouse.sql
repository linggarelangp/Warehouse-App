-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               8.0.30 - MySQL Community Server - GPL
-- Server OS:                    Win64
-- HeidiSQL Version:             12.1.0.6537
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- Dumping structure for table warehouse.products
CREATE TABLE IF NOT EXISTS `products` (
  `id` int NOT NULL AUTO_INCREMENT,
  `productId` varchar(6) NOT NULL,
  `productName` varchar(30) NOT NULL,
  `productStock` int NOT NULL,
  `productPrice` int NOT NULL,
  `createdAt` date NOT NULL,
  `updatedAt` date NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `productId` (`productId`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table warehouse.products: ~8 rows (approximately)
REPLACE INTO `products` (`id`, `productId`, `productName`, `productStock`, `productPrice`, `createdAt`, `updatedAt`) VALUES
	(1, 'PRD001', 'Beras', 200, 50000, '2023-12-01', '2023-12-11'),
	(2, 'PRD002', 'Kecap Manis', 500, 5000, '2023-12-01', '2023-12-01'),
	(3, 'PRD003', 'Kecap Asin', 500, 4000, '2023-12-01', '2023-12-01'),
	(7, 'PRD004', 'Fanta', 200, 5000, '2023-12-03', '2023-12-03'),
	(9, 'PRD005', 'Sprite', 200, 3500, '2023-12-12', '2023-12-12'),
	(18, 'PRD006', 'Kopi', 31, 12000, '2023-12-12', '2023-12-12'),
	(19, 'PRD007', 'Coca Cola', 200, 8000, '2023-12-12', '2023-12-12'),
	(20, 'PRD008', 'Gula', 1000, 12000, '2023-12-12', '2023-12-12');

-- Dumping structure for table warehouse.user
CREATE TABLE IF NOT EXISTS `user` (
  `id` int NOT NULL AUTO_INCREMENT,
  `userId` int NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` text NOT NULL,
  `active` tinyint NOT NULL,
  `role` enum('admin','staff') NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `user_id` (`userId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table warehouse.user: ~1 rows (approximately)
REPLACE INTO `user` (`id`, `userId`, `username`, `password`, `active`, `role`) VALUES
	(1, 1, 'admin', 'admin', 1, 'admin');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
