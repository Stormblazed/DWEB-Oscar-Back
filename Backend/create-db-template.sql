-- Active: 1636070085504@@127.0.0.1@3306
CREATE SCHEMA IF NOT EXISTS `DWEB_Oscar_banco` DEFAULT CHARACTER SET utf8 ;


-- MySQL Script generated by MySQL Workbench
-- Sun Jun 11 15:49:18 2023
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema DWEB_Oscar_banco
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema DWEB_Oscar_banco
-- -----------------------------------------------------

USE `DWEB_Oscar_banco` ;

-- -----------------------------------------------------
-- Table `DWEB_Oscar_banco`.`ator`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `DWEB_Oscar_banco`.`ator` ;

CREATE TABLE IF NOT EXISTS `DWEB_Oscar_banco`.`ator` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `dataNasc` DATE NOT NULL,
  `totindi` INT NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DWEB_Oscar_banco`.`diretor`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `DWEB_Oscar_banco`.`diretor` ;

CREATE TABLE IF NOT EXISTS `DWEB_Oscar_banco`.`diretor` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `dataNasc` DATE NOT NULL,
  `totIndi` INT NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DWEB_Oscar_banco`.`ondeAssistir`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `DWEB_Oscar_banco`.`ondeAssistir` ;

CREATE TABLE IF NOT EXISTS `DWEB_Oscar_banco`.`ondeAssistir` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `url` VARCHAR(45) NOT NULL,
  `plataforma` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DWEB_Oscar_banco`.`filme`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `DWEB_Oscar_banco`.`filme` ;

CREATE TABLE IF NOT EXISTS `DWEB_Oscar_banco`.`filme` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `totIndi` INT NOT NULL,
  `ondeAssistir_id` INT NOT NULL,
  `diretor_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_filme_ondeAssistir_idx` (`ondeAssistir_id`) VISIBLE,
  INDEX `fk_filme_diretor1_idx` (`diretor_id`) VISIBLE,
  CONSTRAINT `fk_filme_ondeAssistir`
    FOREIGN KEY (`ondeAssistir_id`)
    REFERENCES `DWEB_Oscar_banco`.`ondeAssistir` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_filme_diretor1`
    FOREIGN KEY (`diretor_id`)
    REFERENCES `DWEB_Oscar_banco`.`diretor` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DWEB_Oscar_banco`.`categoria`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `DWEB_Oscar_banco`.`categoria` ;

CREATE TABLE IF NOT EXISTS `DWEB_Oscar_banco`.`categoria` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `descricao` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DWEB_Oscar_banco`.`categoria_has_filme`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `DWEB_Oscar_banco`.`categoria_has_filme` ;

CREATE TABLE IF NOT EXISTS `DWEB_Oscar_banco`.`categoria_has_filme` ( 
 `id` INT NOT NULL AUTO_INCREMENT,
  `categoria_id` INT NOT NULL,
  `filme_id` INT NOT NULL, 
  PRIMARY KEY (`id`),
  INDEX `fk_categoria_has_filme_filme1_idx` (`filme_id` ) VISIBLE,
  INDEX `fk_categoria_has_filme_categoria1_idx` (`categoria_id` ) VISIBLE,
  CONSTRAINT `fk_categoria_has_filme_categoria1`
    FOREIGN KEY (`categoria_id`)
    REFERENCES `DWEB_Oscar_banco`.`categoria` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_categoria_has_filme_filme1`
    FOREIGN KEY (`filme_id`)
    REFERENCES `DWEB_Oscar_banco`.`filme` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DWEB_Oscar_banco`.`filme_has_ator`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `DWEB_Oscar_banco`.`filme_has_ator` ;

CREATE TABLE IF NOT EXISTS `DWEB_Oscar_banco`.`filme_has_ator` (
 `id` INT NOT NULL AUTO_INCREMENT,
  `filme_id` INT NOT NULL,
  `ator_id` INT NOT NULL,  
   PRIMARY KEY (`id`),
  INDEX `fk_filme_has_ator_ator1_idx` (`ator_id` ) VISIBLE,
  INDEX `fk_filme_has_ator_filme1_idx` (`filme_id` ) VISIBLE,
  CONSTRAINT `fk_filme_has_ator_filme1`
    FOREIGN KEY (`filme_id`)
    REFERENCES `DWEB_Oscar_banco`.`filme` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_filme_has_ator_ator1`
    FOREIGN KEY (`ator_id`)
    REFERENCES `DWEB_Oscar_banco`.`ator` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
