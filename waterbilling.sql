-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 19, 2023 at 03:08 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `waterbilling`
--

-- --------------------------------------------------------

--
-- Table structure for table `account`
--

CREATE TABLE `account` (
  `account_id` int(20) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `name` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `account`
--

INSERT INTO `account` (`account_id`, `username`, `password`, `name`) VALUES
(16, 'user', '0c95c7ece1ce1a975027', 'Catherine');

-- --------------------------------------------------------

--
-- Table structure for table `billing_info`
--

CREATE TABLE `billing_info` (
  `billing_id` int(20) NOT NULL,
  `client_id` int(20) NOT NULL,
  `month` varchar(20) NOT NULL,
  `year` year(4) NOT NULL,
  `date` date NOT NULL,
  `status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `billing_info`
--

INSERT INTO `billing_info` (`billing_id`, `client_id`, `month`, `year`, `date`, `status`) VALUES
(46, 30, 'December', '2023', '2023-12-18', 'Paid'),
(47, 31, 'December', '2023', '2023-12-18', 'Paid'),
(48, 32, 'December', '2023', '2023-12-18', 'Paid'),
(49, 33, 'December', '2023', '2023-12-18', 'Paid'),
(50, 34, 'December', '2023', '2023-12-18', 'Paid'),
(51, 35, 'December', '2023', '2023-12-18', 'Paid'),
(52, 36, 'December', '2023', '2023-12-18', 'Paid'),
(53, 37, 'December', '2023', '2023-12-18', 'Paid');

-- --------------------------------------------------------

--
-- Table structure for table `bill_record`
--

CREATE TABLE `bill_record` (
  `bill_id` int(11) NOT NULL,
  `name` varchar(20) NOT NULL,
  `date` date NOT NULL,
  `month` varchar(20) NOT NULL,
  `year` year(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bill_record`
--

INSERT INTO `bill_record` (`bill_id`, `name`, `date`, `month`, `year`) VALUES
(7, 'Catherine Medilo', '2023-12-18', 'December', '2023'),
(8, 'Sesenia Medilo', '2023-12-18', 'December', '2023');

-- --------------------------------------------------------

--
-- Table structure for table `client_info`
--

CREATE TABLE `client_info` (
  `client_id` int(20) NOT NULL,
  `last_name` varchar(20) NOT NULL,
  `first_name` varchar(20) NOT NULL,
  `middle_name` varchar(20) NOT NULL,
  `contact_no` varchar(20) NOT NULL,
  `purok` int(20) NOT NULL,
  `month` varchar(20) NOT NULL,
  `year` year(4) NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `client_info`
--

INSERT INTO `client_info` (`client_id`, `last_name`, `first_name`, `middle_name`, `contact_no`, `purok`, `month`, `year`, `date`) VALUES
(36, 'Medilo', 'Catherine', 'Fegi', '09656246650', 3, 'December', '2023', '2023-12-18'),
(37, 'Medilo', 'Sesenia', 'Fegi', '09618862014', 2, 'December', '2023', '2023-12-18');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`account_id`);

--
-- Indexes for table `billing_info`
--
ALTER TABLE `billing_info`
  ADD PRIMARY KEY (`billing_id`);

--
-- Indexes for table `bill_record`
--
ALTER TABLE `bill_record`
  ADD PRIMARY KEY (`bill_id`);

--
-- Indexes for table `client_info`
--
ALTER TABLE `client_info`
  ADD PRIMARY KEY (`client_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `account`
--
ALTER TABLE `account`
  MODIFY `account_id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `billing_info`
--
ALTER TABLE `billing_info`
  MODIFY `billing_id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=54;

--
-- AUTO_INCREMENT for table `bill_record`
--
ALTER TABLE `bill_record`
  MODIFY `bill_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `client_info`
--
ALTER TABLE `client_info`
  MODIFY `client_id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
