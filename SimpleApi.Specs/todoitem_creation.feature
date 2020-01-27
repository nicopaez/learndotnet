Feature: TodoItem creation

Scenario: Creation should assign unique Id
  When I create a TodoItem
  Then I get an Id  