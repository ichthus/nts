/*
CREATE TABLE IF NOT EXISTS `nts_budget_items` (
    `bgtkey` INT NOT NULL AUTO_INCREMENT PRIMARY KEY COMMENT 'primary key',
    `userkey` INT NOT NULL COMMENT 'user''s primary key',
    `name` VARCHAR( 64 ) NOT NULL COMMENT 'Name of the item in the budget',
    `date` TIMESTAMP NOT NULL COMMENT 'Date/Time this item kicks in',
    `amount` FLOAT NOT NULL COMMENT 'Amount of money. Positive income. Negative expenditure.',
    `descr` VARCHAR( 512 ) NULL COMMENT 'Description of an item',
    `catkey` INT NOT NULL COMMENT 'Category key of item',
    PRIMARY KEY (`pkey`),
) ENGINE = MYISAM ;

*/

public class BudgetItem
{
	private float _amt;  	//The amount of the item
	private string _category; // category of item (Income, Bill, Grocery, Household item, Clothing, Entertaniment, Misc)
	private string _desc;	//The descriptor of the item 
	private string _date;	//The date the item occurs
	private int _id;		//The ID of the item
	
	public BudgetItem()
	{}

	public BudgetItem(string date, string category, string desc, float amt)
	{
		_amt=amt;
		_category=category;
		_desc=desc;
		_date=date;
		// create id (DB) 
	}
    
	public int ID
	{
		get {return _id;}
	}

	public float Amt
	{
		get {return _amt;}
		set {_amt = value;}
	}
	
	public string Date
	{
		get {return _date;}
		set {_date = value;}
	}
	
	
	public string Category
	{
		get {return _category;}
		set {_category = value;}
	}
    
	public string Description
	{
		get {return _desc;}
		set {_desc = value;}
	}
	
	public void storeItem()
	{
		//Stores in the database
	}
}


