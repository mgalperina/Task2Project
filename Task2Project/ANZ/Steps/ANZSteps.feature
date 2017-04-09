Feature: ANZSteps

@anztests
Scenario Outline: Calculate payments for home loan and different income
	Given I navigate to http://www.anz.co.nz/personal/ url
	When I select Home loan borrowing calculator tab
	And I type <Income> into an income field
	And I click Calculate to calculate
	Then I should see <Repayments> for each income rate
	Examples: 
	| Income | Repayments |
	| 100000 | $729,000   |
	| 45000  | $265,000   |
	| 200000 | $1,560,000 |

	Scenario Outline: Calculate payments for home loan with joint accounts
	Given I navigate to http://www.anz.co.nz/personal/ url
	When I select Home loan borrowing calculator tab
	And I choose Joint application
	And I type <Income> into an income field
	And I click Calculate to calculate
	Then I should see <Repayments> for each income rate 
	Examples: 
	| Income | Repayments |
	| 100000 | $646,000   |
	| 45000  | $182,000   |
	| 200000 | $1,477,000 | 

	Scenario Outline: Calculate repayments for home loan with one dependant child and joint application
	Given I navigate to http://www.anz.co.nz/personal/ url
	When I select Home loan borrowing calculator tab
	And I choose Joint application
	And I type <Income> into an income field
	And I add one dependant child
	And I click Calculate to calculate
	Then I should see <Repayments> for each income rate 
	Examples: 
	| Income | Repayments |
	| 100000 | $602,000   |
	| 45000  | $138,000   |
	| 200000 | $1,433,000 | 

	Scenario Outline: Calculate repayments for home loan with one dependant child and joint application and one vehicle
	Given I navigate to http://www.anz.co.nz/personal/ url
	When I select Home loan borrowing calculator tab
	And I choose Joint application
	And I type <Income> into an income field
	And I add one dependant child
	And I add one vehicle
	And I click Calculate to calculate
	Then I should see <Repayments> for each income rate 
	Examples: 
	| Income | Repayments |
	| 100000 | $542,000   |
	| 45000  | $78,000    |
	| 200000 | $1,373,000 | 

	Scenario: Reach the home loan application
	Given I navigate to http://www.anz.co.nz/personal/ url
	And I click Personal tab
	And I click Mortgages button
	And I click Buying your first home button
	And I click  Start your application button
	Then I should see Start your ANZ home loan application name of the page