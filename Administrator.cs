/*
  Administrator class
    inherits Account
    
    
    CREATE TABLE IF NOT EXISTS `nts_admins` (
        `admkey` int(11) NOT NULL AUTO_INCREMENT COMMENT 'primary key',
        `userkey` int(11) NOT NULL COMMENT 'user''s primary key',
        PRIMARY KEY (`admkey`)
    ) ENGINE=MyISAM DEFAULT CHARSET=ascii AUTO_INCREMENT=1;
*/

public class Administrator : Account {

	public Administrator(string name, int id) : base(name, id)
	{
		
	}
	
    public void ChangeStatus(int id) {
	// flip the flag in the database that sets the user as an administrator
    }

    public void CreateUser(string name, int passwd) {

        //Account acct = new Account(name, passwd);
    }

    public void DeleteUser(String name) {
    	//Remove a user and all associated records from the database
    }

    public void ChangeUserPwd(string name, int passwd) {
	//Change the password stored for a user in the database
    }
}