Feature: UsingCalculatorAvailability
	In order to calculate MTBF and Availability
	As someone who struggles with math
	I want to be able to use my calculator to do this

@Availability
	Scenario: Calculating MTBFs
	When I have entered "20" and "40" into the calculator and press MTBF 
	Then the availability result should be "60"
       
@Availability
	Scenario: Calculating Availability
	When I have entered "100" and "20" into the calculator and press Availability 
	Then the availability result should be "80"