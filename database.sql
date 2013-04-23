CREATE TABLE IF NOT EXISTS `nts_users` (
    `userkey` int(11) NOT NULL AUTO_INCREMENT COMMENT 'primary key',
    `username` varchar(64) NOT NULL COMMENT 'user name',
    `password` varchar(60) NOT NULL COMMENT 'bcrypt hash',
    `realname` varchar(64) DEFAULT NULL COMMENT 'User''s Real Name',
    `lastlogin` timestamp NULL DEFAULT CURRENT_TIMESTAMP COMMENT 'Timestamp of user''s last logon',
    PRIMARY KEY (`userkey`),
    UNIQUE KEY `username` (`username`)
) ENGINE=MyISAM DEFAULT CHARSET=ascii AUTO_INCREMENT=1 ;


CREATE TABLE IF NOT EXISTS `nts_admins` (
    `admkey` int(11) NOT NULL AUTO_INCREMENT COMMENT 'primary key',
    `userkey` int(11) NOT NULL COMMENT 'user''s primary key',
    PRIMARY KEY (`admkey`)
) ENGINE=MyISAM DEFAULT CHARSET=ascii AUTO_INCREMENT=1; 


CREATE TABLE IF NOT EXISTS `nts_budget_items` (
    `bgtkey` INT NOT NULL AUTO_INCREMENT COMMENT 'primary key',
    `userkey` INT NOT NULL COMMENT 'user''s primary key',
    `name` VARCHAR( 64 ) NOT NULL COMMENT 'Name of the item in the budget',
    `date` TIMESTAMP NOT NULL COMMENT 'Date/Time this item kicks in',
    `amount` FLOAT NOT NULL COMMENT 'Amount of money. Positive income. Negative expenditure.',
    `descr` VARCHAR( 512 ) NULL COMMENT 'Description of an item',
    `catkey` INT NOT NULL COMMENT 'Category key of item',
    PRIMARY KEY (`bgtkey`)
) ENGINE=MyISAM DEFAULT CHARSET=ascii AUTO_INCREMENT=1;


CREATE TABLE IF NOT EXISTS `nts_budget_category` (
    `catkey` INT NOT NULL AUTO_INCREMENT COMMENT 'primary key',
    `income` BOOLEAN NOT NULL COMMENT 'Income is true. Expenditure is false.',
    `name` VARCHAR( 64 ) NOT NULL COMMENT 'Name of the budget item type.',
    `descr` VARCHAR( 512 ) NULL COMMENT 'Description of the budget item type',
    PRIMARY KEY (`catkey`)
) ENGINE=MyISAM DEFAULT CHARSET=ascii AUTO_INCREMENT=1;