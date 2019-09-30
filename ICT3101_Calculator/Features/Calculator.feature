Feature: UsingCalculatorDivisions
    In order to conquer divisions
    As a division enthusiast
    I want to understand a variety of division operations
    	
@Addition
Scenario: Add two numbers
    When I have entered "50" and "70" into the calculator and press add
    Then the result should be "120"

@Additionv2
Scenario Outline: Add zeros for special cases
    When I have entered "<value1>" and "<value2>" into the calculator and press add
    Then the result should be "<value3>"
    Examples: 
     | value1 | value2 | value3 |
     | 0      | 20     | 2      |
     | 20     | 0      | 200    |
     | 0      | 0      | 666    |
     
@Divisions
Scenario: Dividing two numbers
    When I have entered "1" and "2" into the calculator and press divide 
    Then the division result should be "0.5"

@Divisions
Scenario: Dividing zero by a number
    When I have entered "0" and "15" into the calculator and press divide 
    Then the division result should be "0"

@Divisions
Scenario: Dividing by zeros
    When I have entered "15" and "0" into the calculator and press divide 
    Then the division result should be Infinity on the screen

@Divisions
Scenario: Dividing by zero by zero Given I have a calculator
    When I have entered "0" and "0" into the calculator and press divide 
    Then the division result should be "1"