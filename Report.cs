using System;

public class Report
{
    
	private     BudgetItem[]  _aBudget;		//array of budget items
	private     string      _beginDate;		//begin date of report
	private     string      _endDate;		//end date of report
    
    public Report()
    {
        
        //
    }
	
	public string BeginDate
	{
		get
		{
			return _beginDate;
		}
		set
		{
			_beginDate = bDate;
		}
	}
    
	
	public string EndDate
	{
		get
		{
			return _endDate;
		}
		set
		{
			_endDate = eDate;
		}
	}
    
	public void process()
	{
		//get 
		// go to DB, fill array with budget items from begin date to end date
        
		// calculate net amount from income and expenditures
		float netAmount = 0; // net funds
		float income = 0; // income
		float totalExp = 0; // total expenditures
		float bills = 0; // bills
		float groceries = 0; // groceries
		float hhItem = 0; // household item
		float clothes = 0; // clothing
		float ent = 0; // entertainment
		float misc = 0; // crack funds
		float curAmt = 0; // amount of current BudgetItem
		string curCat = ""; // category of current BudgetItem
		
		for (int i = 0; i < _aBudget.Length; i++) { 
		    curAmt = _aBudget[i].Amt;
		    curCat = _aBudget[i].Cat;
		    switch (curCat) {
			case "Income":
			    income += curAmt;
			    netAmount += curAmt;
			    break;
			case "Bill":
			    totalExp += curAmt;
			    bills += curAmt;
			    netAmount -= curAmt;
			    break;
			case "Grocery":
			    totalExp += curAmt;
			    groceries += curAmt;
			    netAmount -= curAmt;
			    break;
			case "Household Item":
			    totalExp += curAmt;
			    hhItem += curAmt;
			    netAmount -= curAmt;
			    break;
			case "Clothing":
			    totalExp += curAmt;
			    clothes += curAmt;
			    netAmount -= curAmt;
			    break;
			case "Entertainment":
			    totalExp += curAmt;
			    ent += curAmt;
			    netAmount -= curAmt;
			    break;
			case "Misc":
			    totalExp += curAmt;
			    misc += curAmt;
			    netAmount -= curAmt;
			    break;
		    }
		}
		
		// make suggestions for expenditure improvement?
		
		// print report 
		// redirect output to GUI
		//redirectSystemStreams();
		
		Console.WriteLine("Total Income: " {0}, income);
		Console.WriteLine("Total Expenditures: " {0}, totalExp);
		Console.WriteLine("Total Bills: " {0}, bills);
		Console.WriteLine("Total Groceries: " {0}, groceries);
		Console.WriteLine("Total Household Items: " {0}, hhItem);
		Console.WriteLine("Total Clothing Amount: " {0}, clothes);
		Console.WriteLine("Total Entertainment: " {0}, ent);
		Console.WriteLine("Total Miscellaneous Expenditures: " {0}, misc);
		
		if (netAmount < 0)
		    Console.WriteLine("Amount Overdrawn: " {0}, netAmount);
		else
		    Console.WriteLine("Amount Leftover: " {0}, netAmount);
			
		return;
	}
    
}