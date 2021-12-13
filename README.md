
# C#: From Zero To Hero
## Chapter 3: C#. Homework: Advanced LINQ
### Intro
LINQ is a powerful tool not only to filter data, but also to transform it. All the common operations
that you would do in a foreach loop can, and in most cases should be done using LINQ.
Even though LINQ is not the fastest, it is still good enough for daily programming tasks as it makes code
much more readable and it's efficient (time-wise) to write code using LINQ.

Anonymous object is a nice addition for selecting something without a defined type. Sometimes we just
want to print the results and that purpose anonymous object serves just fine.

### Task
All transactions within the shops are known: what, when, where and for how much was an item baught.

Create a command line program that accepts the following arguments, 

`programname "path/to/input" "command" "path/to/output"`. The "command" format will be specified in the requirements below (`in parantheses`).

You need to generate the following reports:  

1) By time (`time`)
    - how many items have been bought during every hour of time of day,
    - how much money did every hour total (on average), 
    - and get rush hour (most mony earned on average).

Support getting items sold count and money earned for a selected range of hours as well.

2) What city (can be parsed from address) earned the most/least money and what city sold the most/least items? (`city [-min/-max] [-items/-money]`)

--- Extra challenge:

3) Daily money earned for specific shop. (`daily Shop Name`)

4) What items were sold in what shop, at what price and when (file, named after shop).  (`full`)

Results should be printed to a file in .csv format.

(3) and (4) supports sorting by shop name (or city name) in either ascending or descending order. If not sorting is provided, it should sort in ascending order. Sorting is just 1 extra arg: -asc (sorts in ascending order by shop name); -desc (sorts in descending order by shop name)

### Example Command Invocations

Here's a list of example command invocations to get you started. It is not an exhaustive list of required supported commands.

1) `"path/to/input" "time" "path/to/output"` - Output the report specified in requirement 1.

2) `"path/to/input" "time 11:00-17:00" "path/to/output"` - Output the report specified in requirement 1, filtered on transactions between the time of day 11:00 - 17:00.

3) `"path/to/input" "city -money -max" "path/to/output"` - Output the report specified in requirement 2, determining the city where the most money is earned. 

Note: No UI.
=======
# C#: From Zero To Hero 
# The vision
"Programming is hard". Yes, but not harder than running a marathon for a person who has never run. It's not harder than 
building a house if you never built one. Programming is hard only until you practice it (like any other skill). 
I would like to invite you to learn programming and C# following this course. 
Ignite passion for finding little miracles in code every day 🙂

# For new joiners
It's never too late to join, because the community is there, all the material is saved
and you will not be left alone.

Live lessons material (slides + videos + examples + homework) here:  
https://github.com/csinn/CSharp-From-Zero-To-Hero/wiki/Summary

New joiner's guide here:  
https://github.com/csinn/CSharp-From-Zero-To-Hero/wiki/New-joiner-guide  
![Boot Camp Banner](Res/kaisi_banner.png)

