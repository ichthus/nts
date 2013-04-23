/*
 CREATE TABLE IF NOT EXISTS `nts_users` (
    `userkey` int(11) NOT NULL AUTO_INCREMENT COMMENT 'primary key',
    `username` varchar(64) NOT NULL COMMENT 'user name',
    `password` varchar(60) NOT NULL COMMENT 'bcrypt hash',
    `realname` varchar(64) DEFAULT NULL COMMENT 'User''s Real Name',
    `lastlogin` timestamp NULL DEFAULT CURRENT_TIMESTAMP COMMENT 'Timestamp of user''s last logon',
    PRIMARY KEY (`pkey`),
    UNIQUE KEY `username` (`username`)
) ENGINE=MyISAM DEFAULT CHARSET=ascii AUTO_INCREMENT=1 ;
*/

public class Account {
	private string _name;
	private int _id;
	
	
	public Account(string name, int id) {
		_name = name;
		_id = id;
	}
    
	public string ChangeName {
		set {
			_name = newName;  
		}
	}
    
	public void ChangeMyPwd(int newPwd) {
	 // access database   
	}
    
	public int ID {
		get {
			return _id;  
		}
	}
    
    public void SaveAccount() {
        // access database
    }
}