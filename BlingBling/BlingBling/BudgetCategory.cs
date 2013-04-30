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
	private string  _name;       // Name of the budget item type.
	private string  _descr;      // Description of the budget item type

  public BudgetCategory(int c, string n)
  {
    _catkey = c;
    _name = n;
  }

  public BudgetCategory(int c, string n, string d)
  {
    _catkey = c;
    _name = n;
    _descr = d;
  }

  public int Value
  {
    get
    {
      return _catkey;
    }
  }

  public string Text
  {

    get
    {
      return _name;
    }
  }

  public string Description
  {
    get
    {
      return _descr;
    }
  }
  public string ToString()
  {
    return _name;
  }
}