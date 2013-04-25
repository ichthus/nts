/*
CREATE TABLE IF NOT EXISTS `nts_budget_category` (
    `catkey` INT NOT NULL AUTO_INCREMENT PRIMARY KEY COMMENT 'primary key',
    `income` BOOLEAN NOT NULL COMMENT 'Income is true. Expenditure is false.',
    `name` VARCHAR( 64 ) NOT NULL COMMENT 'Name of the budget item type.',
    `descr` VARCHAR( 512 ) NULL COMMENT 'Description of the budget item type',
    PRIMARY KEY (`catkey`),
) ENGINE = MYISAM ;
*/

public class BudgetCategory
{
	private int     _catkey;     // primary key
	private bool _income;     // Income is true. Expenditure is false.
	private string  _name;       // Name of the budget item type.
	private string  _descr;      // Description of the budget item type
	    
	   //add functions.
}