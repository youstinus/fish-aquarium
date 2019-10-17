-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: 2019 m. Spa 16 d. 19:35
-- Server version: 5.7.23
-- PHP Version: 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `fish_aquarium`
--

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `Allergens`
--

DROP TABLE IF EXISTS `Allergens`;
CREATE TABLE IF NOT EXISTS `Allergens` (
  `Id` int(11)  NOT NULL AUTO_INCREMENT,
  `name` char(7) COLLATE utf8_lithuanian_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `Aquarium`
--

DROP TABLE IF EXISTS `Aquariums`;
CREATE TABLE IF NOT EXISTS `Aquariums` (
  `Capacity` double DEFAULT NULL,
  `Mass` double DEFAULT NULL,
  `Length` double DEFAULT NULL,
  `Width` double DEFAULT NULL,
  `Heigth` double DEFAULT NULL,
  `GlassThickness` int(11) DEFAULT NULL,
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Fk_Portion` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `Fkc_Portion` (`Fk_Portion`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `Aquarium_inside_has_decoration`
--

DROP TABLE IF EXISTS `Aquarium_inside_has_decoration`;
CREATE TABLE IF NOT EXISTS `Aquarium_inside_has_decoration` (
  `Fk_decoration` int(11) NOT NULL,
  `Fk_aquarium` int(11) NOT NULL,
  PRIMARY KEY (`Fk_decoration`,`Fk_aquarium`),
  KEY `Fkc_Aquarium` (`Fk_aquarium`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `Decoration`
--

DROP TABLE IF EXISTS `Decorations`;
CREATE TABLE IF NOT EXISTS `Decorations` (
  `Manufacturer` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Name` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Color` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Mass` double DEFAULT NULL,
  `Description` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Material` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Type` int(11) DEFAULT NULL,
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`Id`),
  KEY `Type` (`Type`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `DecorationTypes`
--

DROP TABLE IF EXISTS `DecorationTypes`;
CREATE TABLE IF NOT EXISTS `DecorationTypes` (
  `Id` int(11) NOT NULL,
  `name` char(14) COLLATE utf8_lithuanian_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `Equipment`
--

DROP TABLE IF EXISTS `Equipments`;
CREATE TABLE IF NOT EXISTS `Equipments` (
  `Manufacturer` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Name` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Type` int(11) DEFAULT NULL,
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`Id`),
  KEY `Type` (`Type`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `EquipmentTypes`
--

DROP TABLE IF EXISTS `EquipmentTypes`;
CREATE TABLE IF NOT EXISTS `EquipmentTypes` (
  `Id` int(11) NOT NULL,
  `name` char(11) COLLATE utf8_lithuanian_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `Equipment_put_in_aquarium`
--

DROP TABLE IF EXISTS `Equipment_put_in_aquarium`;
CREATE TABLE IF NOT EXISTS `Equipment_put_in_aquarium` (
  `Fk_aquarium` int(11) NOT NULL,
  `Fk_equipment` int(11) NOT NULL,
  PRIMARY KEY (`Fk_aquarium`,`Fk_equipment`),
  KEY `Fkc_Equipment` (`Fk_equipment`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `Fish`
--

DROP TABLE IF EXISTS `Fishes`;
CREATE TABLE IF NOT EXISTS `Fishes` (
  `Species` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Mass` double DEFAULT NULL,
  `Size` double DEFAULT NULL,
  `Origin` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `ArrivalDate` date DEFAULT NULL,
  `LifeExpectancy` int(11) DEFAULT NULL,
  `Description` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Gender` int(11) DEFAULT NULL,
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Fk_Aquarium` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `Gender` (`Gender`),
  KEY `Fkc_Aquarium` (`Fk_Aquarium`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `FishGenderTypes`
--

DROP TABLE IF EXISTS `FishGenderTypes`;
CREATE TABLE IF NOT EXISTS `FishGenderTypes` (
  `Male` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Id` int(11) NOT NULL,
  `name` char(12) COLLATE utf8_lithuanian_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `Food`
--

DROP TABLE IF EXISTS `Foods`;
CREATE TABLE IF NOT EXISTS `Foods` (
  `Name` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Mass` double DEFAULT NULL,
  `Calories` double DEFAULT NULL,
  `Carbs` double DEFAULT NULL,
  `Proten` double DEFAULT NULL,
  `Fat` double DEFAULT NULL,
  `PrepManual` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `ExpirationDate` date DEFAULT NULL,
  `Allergen` int(11) DEFAULT NULL,
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`Id`),
  KEY `Allergen` (`Allergen`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `Food_mixed_in_portion`
--

DROP TABLE IF EXISTS `Food_mixed_in_portion`;
CREATE TABLE IF NOT EXISTS `Food_mixed_in_portion` (
  `Fk_portion` int(11) NOT NULL,
  `Fk_food` int(11) NOT NULL,
  PRIMARY KEY (`Fk_portion`,`Fk_food`),
  KEY `Fkc_Food` (`Fk_food`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `ItemParameters`
--

DROP TABLE IF EXISTS `ItemParameters`;
CREATE TABLE IF NOT EXISTS `ItemParameters` (
  `Name` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Value` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Type` int(11) DEFAULT NULL,
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Fk_Fish` int(11) DEFAULT NULL,
  `Fk_Aquarium` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Fk_Fish` (`Fk_Fish`),
  KEY `Type` (`Type`),
  KEY `Fkc_Aquarium` (`Fk_Aquarium`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `ParametersTypes`
--

DROP TABLE IF EXISTS `ParametersTypes`;
CREATE TABLE IF NOT EXISTS `ParametersTypes` (
  `Id` int(11) NOT NULL,
  `name` char(15) COLLATE utf8_lithuanian_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `Portion`
--

DROP TABLE IF EXISTS `Portions`;
CREATE TABLE IF NOT EXISTS `Portions` (
  `PreparationDate` date DEFAULT NULL,
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `Supplement`
--

DROP TABLE IF EXISTS `Supplements`;
CREATE TABLE IF NOT EXISTS `Supplements` (
  `Name` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Mass` double DEFAULT NULL,
  `Manual` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `FoodComposition` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `ExpirationDate` date DEFAULT NULL,
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `Supplement_part_of_portion`
--

DROP TABLE IF EXISTS `Supplement_part_of_portion`;
CREATE TABLE IF NOT EXISTS `Supplement_part_of_portion` (
  `Fk_portion` int(11) NOT NULL,
  `Fk_supplement` int(11) NOT NULL,
  PRIMARY KEY (`Fk_portion`,`Fk_supplement`),
  KEY `Fkc_Supplement` (`Fk_supplement`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `AquariumTasks`
--

DROP TABLE IF EXISTS `AquariumTasks`;
CREATE TABLE IF NOT EXISTS `AquariumTasks` (
  `Name` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Duration` double DEFAULT NULL,
  `StartTime` date DEFAULT NULL,
  `Description` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `State` int(11) DEFAULT NULL,
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Fk_Aquarium` int(11) DEFAULT NULL,
  `Fk_User` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `State` (`State`),
  KEY `Fkc_Aquarium` (`Fk_Aquarium`),
  KEY `Fkc_User` (`Fk_User`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `TaskStates`
--

DROP TABLE IF EXISTS `TaskStates`;
CREATE TABLE IF NOT EXISTS `TaskStates` (
  `Id` int(11) NOT NULL,
  `name` char(9) COLLATE utf8_lithuanian_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `AquariumUsers`
--

DROP TABLE IF EXISTS `AquariumUsers`;
CREATE TABLE IF NOT EXISTS `AquariumUsers` (
  `FirstName` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `LastName` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `BirthDate` date DEFAULT NULL,
  `RegistrationDate` date DEFAULT NULL,
  `Email` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Password` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Code` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Type` int(11) DEFAULT NULL,
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`Id`),
  KEY `Type` (`Type`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `UserTypes`
--

DROP TABLE IF EXISTS `UserTypes`;
CREATE TABLE IF NOT EXISTS `UserTypes` (
  `Id` int(11) NOT NULL,
  `name` char(7) COLLATE utf8_lithuanian_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
