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
-- Sukurta duomenų struktūra lentelei `AllergenTypes`
--

DROP TABLE IF EXISTS `AllergenTypes`;
CREATE TABLE IF NOT EXISTS `AllergenTypes` (
  `Id` int(11)  NOT NULL AUTO_INCREMENT,
  `name` char(7) COLLATE utf8_lithuanian_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;
INSERT INTO AllergenTypes(Id, name) VALUES(1, 'Lactose');
INSERT INTO AllergenTypes(Id, name) VALUES(2, 'Gluten');
INSERT INTO AllergenTypes(Id, name) VALUES(3, 'Nuts');

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `Aquarium`
--

DROP TABLE IF EXISTS `Aquarium`;
CREATE TABLE IF NOT EXISTS `Aquarium` (
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
-- Sukurta duomenų struktūra lentelei `AquariumDecoration`
--

DROP TABLE IF EXISTS `AquariumDecoration`;
CREATE TABLE IF NOT EXISTS `AquariumDecoration` (
  `Fk_decoration` int(11) NOT NULL,
  `Fk_aquarium` int(11) NOT NULL,
  PRIMARY KEY (`Fk_decoration`,`Fk_aquarium`),
  KEY `Fkc_Aquarium` (`Fk_aquarium`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `Decoration`
--

DROP TABLE IF EXISTS `Decoration`;
CREATE TABLE IF NOT EXISTS `Decoration` (
  `Manufacturer` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Name` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Color` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Mass` double DEFAULT NULL,
  `Description` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Material` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Type` int(11) DEFAULT NULL,
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`Id`),
  KEY `Type` (`DecorationTypes`)
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
INSERT INTO DecorationTypes(Id, name) VALUES(1, 'Soil');
INSERT INTO DecorationTypes(Id, name) VALUES(2, 'Rubble');
INSERT INTO DecorationTypes(Id, name) VALUES(3, 'Shell');
INSERT INTO DecorationTypes(Id, name) VALUES(4, 'Coral');
INSERT INTO DecorationTypes(Id, name) VALUES(5, 'LivingCreature');
-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `Equipment`
--

DROP TABLE IF EXISTS `Equipment`;
CREATE TABLE IF NOT EXISTS `Equipment` (
  `Manufacturer` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Name` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Type` int(11) DEFAULT NULL,
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`Id`),
  KEY `Type` (`EquipmentTypes`)
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
INSERT INTO EquipmentTypes(Id, name) VALUES(1, 'Filter');
INSERT INTO EquipmentTypes(Id, name) VALUES(2, 'Illuminator');
INSERT INTO EquipmentTypes(Id, name) VALUES(3, 'Bubbler');
INSERT INTO EquipmentTypes(Id, name) VALUES(4, 'Thermostat');
INSERT INTO EquipmentTypes(Id, name) VALUES(5, 'Heater');
-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `Equipment_put_in_aquarium`
--

DROP TABLE IF EXISTS `AquariumEquipment`;
CREATE TABLE IF NOT EXISTS `AquariumEquipment` (
  `Fk_aquarium` int(11) NOT NULL,
  `Fk_equipment` int(11) NOT NULL,
  PRIMARY KEY (`Fk_aquarium`,`Fk_equipment`),
  KEY `Fkc_Equipment` (`Fk_equipment`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `Fish`
--

DROP TABLE IF EXISTS `Fish`;
CREATE TABLE IF NOT EXISTS `Fish` (
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
  KEY `Gender` (`FishGenderTypes`),
  KEY `Fkc_Aquarium` (`Fk_Aquarium`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `FishGenderTypes`
--

DROP TABLE IF EXISTS `FishGenderTypes`;
CREATE TABLE IF NOT EXISTS `FishGenderTypes` (
  `Id` int(11) NOT NULL,
  `name` char(12) COLLATE utf8_lithuanian_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;
INSERT INTO FishGenderTypes(Id, name) VALUES(1, 'Male');
INSERT INTO FishGenderTypes(Id, name) VALUES(2, 'Female');
INSERT INTO FishGenderTypes(Id, name) VALUES(3, 'Hermafrodita');

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `Food`
--

DROP TABLE IF EXISTS `Food`;
CREATE TABLE IF NOT EXISTS `Food` (
  `Name` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Mass` double DEFAULT NULL,
  `Calories` double DEFAULT NULL,
  `Carbs` double DEFAULT NULL,
  `Proten` double DEFAULT NULL,
  `Fat` double DEFAULT NULL,
  `PrepManual` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `ExpirationDate` date DEFAULT NULL,
  `AllergenType` int(11) DEFAULT NULL,
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`Id`),
  KEY `AllergenType` (`AllergenTypes`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `PortionFood`
--

DROP TABLE IF EXISTS `PortionFood`;
CREATE TABLE IF NOT EXISTS `PortionFood` (
  `Fk_portion` int(11) NOT NULL,
  `Fk_food` int(11) NOT NULL,
  PRIMARY KEY (`Fk_portion`,`Fk_food`),
  KEY `Fkc_Food` (`Fk_food`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `ItemParameter`
--

DROP TABLE IF EXISTS `ItemParameter`;
CREATE TABLE IF NOT EXISTS `ItemParameter` (
  `Name` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Value` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Type` int(11) DEFAULT NULL,
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Fk_Fish` int(11) DEFAULT NULL,
  `Fk_Aquarium` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Fk_Fish` (`Fk_Fish`),
  KEY `Type` (`ParameterTypes`),
  KEY `Fkc_Aquarium` (`Fk_Aquarium`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `ParameterTypes`
--

DROP TABLE IF EXISTS `ParameterTypes`;
CREATE TABLE IF NOT EXISTS `ParameterTypes` (
  `Id` int(11) NOT NULL,
  `name` char(15) COLLATE utf8_lithuanian_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;
INSERT INTO ParameterTypes(Id, name) VALUES(1, 'Temperature');
INSERT INTO ParameterTypes(Id, name) VALUES(2, 'O2Concentration');
INSERT INTO ParameterTypes(Id, name) VALUES(3, 'Ph');
INSERT INTO ParameterTypes(Id, name) VALUES(4, 'WaterColor');

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `Portion`
--

DROP TABLE IF EXISTS `Portion`;
CREATE TABLE IF NOT EXISTS `Portion` (
  `PreparationDate` date DEFAULT NULL,
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `Supplement`
--

DROP TABLE IF EXISTS `Supplement`;
CREATE TABLE IF NOT EXISTS `Supplement` (
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
-- Sukurta duomenų struktūra lentelei `PortionSupplement`
--

DROP TABLE IF EXISTS `PortionSupplement`;
CREATE TABLE IF NOT EXISTS `PortionSupplement` (
  `Fk_portion` int(11) NOT NULL,
  `Fk_supplement` int(11) NOT NULL,
  PRIMARY KEY (`Fk_portion`,`Fk_supplement`),
  KEY `Fkc_Supplement` (`Fk_supplement`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `AquariumTask`
--

DROP TABLE IF EXISTS `AquariumTask`;
CREATE TABLE IF NOT EXISTS `AquariumTask` (
  `Name` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Duration` double DEFAULT NULL,
  `StartTime` date DEFAULT NULL,
  `Description` varchar(255) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `StateType` int(11) DEFAULT NULL,
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Fk_Aquarium` int(11) DEFAULT NULL,
  `Fk_User` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `StateType` (`TaskStateTypes`),
  KEY `Fkc_Aquarium` (`Fk_Aquarium`),
  KEY `Fkc_User` (`Fk_User`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `TaskStateTypes`
--

DROP TABLE IF EXISTS `TaskStateTypes`;
CREATE TABLE IF NOT EXISTS `TaskStateTypes` (
  `Id` int(11) NOT NULL,
  `name` char(9) COLLATE utf8_lithuanian_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;
INSERT INTO TaskStateTypes(Id, name) VALUES(1, 'Active');
INSERT INTO TaskStateTypes(Id, name) VALUES(2, 'Canceled');
INSERT INTO TaskStateTypes(Id, name) VALUES(3, 'Completed');

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `AquariumUsers`
--

DROP TABLE IF EXISTS `AquariumUser`;
CREATE TABLE IF NOT EXISTS `AquariumUser` (
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
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;INSERT INTO UserTypes(Id, name) VALUES(1, 'Admin');
INSERT INTO UserTypes(Id, name) VALUES(2, 'Worker');
INSERT INTO UserTypes(Id, name) VALUES(3, 'Visitor');

COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
