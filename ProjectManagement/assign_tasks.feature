Feature: manage tasks
As a Colony
I should be able to assign tasks
And I should be able to order tasks from the task-manager

Scenario: Colony assigns task
  Given the task-manager is active
  When a colony assigns a ResourceCollectTask
    And the task is valid
  Then I should find the task in the task-list
  
  Scenario: Colony assigns invalid task
    Given the task-manager is active
    When a colony assigns a Task
	  And the task is of type NOPTask
	  Or the task is invalid
    Then I should not find the task in the task-list
  
  Scenario: Colony orders a task with highest priority
    Given the task-manager is active
      And the task-list contains a PriorityTask called t1
      And the task-list contains a Task called t2
      And the filter is set to PRIORITY
    When a colony demands a Task
    Then I should not find t1 in the task-list
      And I should find t2 in the task-list
      And I should find t1 in the return variable