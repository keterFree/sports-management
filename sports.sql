-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 11, 2024 at 03:24 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sports`
--

-- --------------------------------------------------------

--
-- Table structure for table `coaches`
--

CREATE TABLE `coaches` (
  `coachid` varchar(10) NOT NULL,
  `firstname` varchar(15) NOT NULL,
  `lastname` varchar(15) NOT NULL,
  `email` varchar(20) NOT NULL,
  `sport` int(11) NOT NULL,
  `contacts` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `events`
--

CREATE TABLE `events` (
  `eventid` int(11) NOT NULL,
  `sport` int(11) NOT NULL,
  `eventname` varchar(50) NOT NULL,
  `time` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `location` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `events`
--

INSERT INTO `events` (`eventid`, `sport`, `eventname`, `time`, `location`) VALUES
(1, 1, 'Semifinals', '2024-03-28 14:05:05', 'Pitch1');

-- --------------------------------------------------------

--
-- Table structure for table `player`
--

CREATE TABLE `player` (
  `player` int(10) NOT NULL,
  `firstname` varchar(15) NOT NULL,
  `lastname` varchar(15) NOT NULL,
  `DOB` date NOT NULL,
  `mobile` varchar(15) NOT NULL,
  `bloodgroup` varchar(5) NOT NULL,
  `emergencycontact` varchar(15) NOT NULL,
  `email` varchar(20) NOT NULL,
  `sport` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `player`
--

INSERT INTO `player` (`player`, `firstname`, `lastname`, `DOB`, `mobile`, `bloodgroup`, `emergencycontact`, `email`, `sport`) VALUES
(2, 'Duncan', 'Komen', '2009-11-18', '+254752315489', 'A+', '+254752231458', 'komen@gmail.com', 4),
(4, 'Samsom', 'Mwite', '2005-07-14', '+254755631774', 'AB+', '+254752223147', 'mwitesammy@gmail.com', 11),
(5, 'Rancliff', 'Sardonie', '2024-03-11', '+254789900154', 'O+', '+254761972654', 'sardonie@gmail.com', 8),
(6, 'James', 'Madisson', '2010-06-16', '+176900978', 'AB-', '+25478890165', 'jammie@gmail.com', 7),
(7, 'George', 'Wafula', '2005-07-14', '+25471377711', 'O+', '+254788991042', 'wafula@gamil.com', 1);

-- --------------------------------------------------------

--
-- Stand-in structure for view `playerevents`
-- (See below for the actual view)
--
CREATE TABLE `playerevents` (
`firstname` varchar(15)
,`lastname` varchar(15)
,`email` varchar(20)
,`sportname` varchar(20)
,`eventname` varchar(50)
,`time` timestamp
,`location` varchar(15)
);

-- --------------------------------------------------------

--
-- Table structure for table `sport`
--

CREATE TABLE `sport` (
  `sportid` int(3) NOT NULL,
  `sportname` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `sport`
--

INSERT INTO `sport` (`sportid`, `sportname`) VALUES
(1, 'Handball'),
(2, 'Basketball'),
(3, 'Karate'),
(4, 'Badminton'),
(5, 'Hockey'),
(6, 'Athletics'),
(7, 'Football'),
(8, 'Tennis'),
(9, 'Chess'),
(10, 'Rugby'),
(11, 'Swimming'),
(12, 'Volleyball');

-- --------------------------------------------------------

--
-- Structure for view `playerevents`
--
DROP TABLE IF EXISTS `playerevents`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `playerevents`  AS SELECT `player`.`firstname` AS `firstname`, `player`.`lastname` AS `lastname`, `player`.`email` AS `email`, `sport`.`sportname` AS `sportname`, `events`.`eventname` AS `eventname`, `events`.`time` AS `time`, `events`.`location` AS `location` FROM ((`player` left join `sport` on(`player`.`sport` = `sport`.`sportid`)) left join `events` on(`events`.`sport` = `sport`.`sportid`)) ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `coaches`
--
ALTER TABLE `coaches`
  ADD PRIMARY KEY (`coachid`),
  ADD KEY `sport` (`sport`);

--
-- Indexes for table `events`
--
ALTER TABLE `events`
  ADD PRIMARY KEY (`eventid`),
  ADD KEY `sport` (`sport`);

--
-- Indexes for table `player`
--
ALTER TABLE `player`
  ADD PRIMARY KEY (`player`),
  ADD KEY `sport` (`sport`);

--
-- Indexes for table `sport`
--
ALTER TABLE `sport`
  ADD PRIMARY KEY (`sportid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `events`
--
ALTER TABLE `events`
  MODIFY `eventid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `player`
--
ALTER TABLE `player`
  MODIFY `player` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `coaches`
--
ALTER TABLE `coaches`
  ADD CONSTRAINT `coaches_ibfk_1` FOREIGN KEY (`sport`) REFERENCES `sport` (`sportid`);

--
-- Constraints for table `events`
--
ALTER TABLE `events`
  ADD CONSTRAINT `events_ibfk_1` FOREIGN KEY (`sport`) REFERENCES `sport` (`sportid`);

--
-- Constraints for table `player`
--
ALTER TABLE `player`
  ADD CONSTRAINT `player_ibfk_1` FOREIGN KEY (`sport`) REFERENCES `sport` (`sportid`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
