# TimeKeepersChallenge

Aim: E-Commerce API for watch ordering


**Solution Architecture:**
  
  ConsoleApp: Startup Project (user interface)
  Models: basic model classes and business logic
  ModelTests: unit testing project



**Work Intruction:**
  
  User Input: comma-separated integer values signifying watch IDs to buy in not particular order
  Output: Total cost incurred for the order, after applying any discount(s) applicable



**Approach:**
  
  The idea was to set up a simple console project and focus mainly on the backend business logic. The Model classes are the basic building blocks of this OOP solution. Separate model classes for watches and orders allow the solution to be modular and scalable. Inventory management can be done separately irrespective of the product being sold. Similarly, orders for different types of products-sold can be managed separately.



**Room for Improvement:**
  
  1. Adding database service to keep track of inventory and orders
  2. Adding logger service for tracking performance and allowing post-failure debugging
  3. Adding configuration service to allow code-less inventory management
  4. Developing a dynamically populating GUI using WPF
