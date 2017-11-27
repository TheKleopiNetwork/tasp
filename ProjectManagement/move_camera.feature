Feature: Move Camera
allowing the user to move around the map

Scenario: User moves camera straight
  Given the camera is active
  When I press the W key
  Or I press the S key
  Then the camera should move with the Z axis
  
Scenario: User moves camera sideways
  Given the camera is active
  When I press the A key
  Or I press the D key
  Then the camera should move with the X axis
  
