-- phpMyAdmin SQL Dump
-- version 4.7.8
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Apr 19, 2018 at 04:08 PM
-- Server version: 5.7.21
-- PHP Version: 7.1.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `lapisappnet_in_movie`
--

-- --------------------------------------------------------

--
-- Table structure for table `fun`
--

CREATE TABLE `fun` (
  `fun_id` int(11) NOT NULL,
  `file_name` varchar(30) NOT NULL,
  `program_name` varchar(30) NOT NULL,
  `type_id` varchar(30) NOT NULL,
  `length` varchar(30) NOT NULL,
  `file_path` varchar(100) NOT NULL,
  `releaseDate` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `fun`
--

INSERT INTO `fun` (`fun_id`, `file_name`, `program_name`, `type_id`, `length`, `file_path`, `releaseDate`) VALUES
(13, 'English', 'clara', '4', '2:56:0', 'video/636597500091053105.ogv', '17');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `log_id` int(10) UNSIGNED NOT NULL,
  `user_id` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `role` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`log_id`, `user_id`, `password`, `role`) VALUES
(1, 'admin', 'admin', '1'),
(2, 'sneha', 'sneha', '2'),
(3, 'minu', 'ann', '2'),
(4, 'sample', 'sam', '2'),
(5, 'alin', 'alin', '2');

-- --------------------------------------------------------

--
-- Table structure for table `registration`
--

CREATE TABLE `registration` (
  `user_id` varchar(30) NOT NULL,
  `name` varchar(30) NOT NULL,
  `address` varchar(100) NOT NULL,
  `email` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `registration`
--

INSERT INTO `registration` (`user_id`, `name`, `address`, `email`) VALUES
('sample', 'sample', 'cochin', 'sam@gmail.com'),
('alin', 'alin', 'pala', 'alin@gmail.com');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `fun`
--
ALTER TABLE `fun`
  ADD PRIMARY KEY (`fun_id`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`log_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `fun`
--
ALTER TABLE `fun`
  MODIFY `fun_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `log_id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
