Feature: Tests
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: 
	Given calculator app is initialized	

@addNum
Scenario Outline: Add two numbers
	When The <firstNumber> number typed at the calculator
	When I select a sign like plus
	When The <secondNumber> number typed at the calculator
	And I tap on equal button
	Then I see the <result> of operation at the input field
	Examples:
    | firstNumber | secondNumber | result	  |
    |    0		  |   0			 |   0		  |
    |    1		  |   0			 |   1		  |
    |    0		  |   1			 |   1		  |
    |    9		  |   1			 |   10       |
