# C#: From Zero To Hero
## Chapter 3: C#. Homework 9: Advanced LINQ
### Intro
LINQ is a powerful tool not only to filter data, but also to transform it. All the common operations
that you would do in a foreach loop can, and in most cases should be done using LINQ.
Even though LINQ is not the fastest, it is still good enough for daily programming tasks as it makes code
much more readable and it's efficient (time-wise) to write code using LINQ.

Anonymous object is a nice addition for selecting something without a defined type. Sometimes we just
want to print the results and that purpose anonymous object serves just fine.

### Task
All transactions within the shops are known: what, when, where and for how much was an item baught.
You need to generate the following reports:

1) By time: how many items have been bought during every hour of a day (on average), how much money did every hour total (on average)? Get rush hour (most mony earned). Support getting items sold count and money earned for a selected range of hours as well
2) How many items did each city cell and how much did it earn? What city (can be parsed from address) earned the most/least money and what city sold the most/least items?

--- Extra challenge:
3) Daily money earned for specific shop.
4) What items were sold in what shop, at what price and when (file, named after shop). Can get a specific shop as well.

The following commands will invoke the following cases:
1) time (returns stats for full day); time 00:00-23:59 (returns stats between 00:00 and 23:59)
2) city -money -max (city that earned most money); city -money -min (city that earned the least money); city -items-max (city that sold the most items); city -items -min (city that sold the least items)  
3) daily "KwikiMart" (gets daily money earned by "KwikiMart")   
4) full (get what did each shop sell); full "KwikiMart" (gets all items sold by "KwikiMart"). Prints all items of one shop first, then next shop items.

Every command should start with a file which contains input and end with a file that contains output.
For example: "input/Transactions.csv" time "time.csv"
Results should be printed to a file in .csv format.

2), 3) and 4) supports sorting by shop name (or city name) in either ascending or descending order. If not sorting is provided, it should sort in ascending order. Sorting is just 1 extra arg: -asc (sorts in ascending order by shop name); -desc (sorts in descending order by shop name)

Note: No UI.
```
