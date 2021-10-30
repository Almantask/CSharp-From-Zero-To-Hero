
# C#: From Zero To Hero
## Chapter 2. Homework 2: Inheritance
### Intro
Inheritance is a swiss army knife of OOP. It is a powerful tool to form strong relations between our **domain objects**.
Using inheritance we can achieve generalization of other objects, reuse code and much more...
However, with great power comes great responsibility. Inheritance should not be overused, exactly because it forms strong relations of our domain objects.
It's hard to design clean inheritance, because it needs to be stable, purely additive and not too deep so we can maintain it easilly.
Prefer composition over inheritance is a principle that should be followed in most cases,
because it allows us to build more modular and less coupled code, with a price of some duplicate code.

### Task
Player has inventory where they store their items. They can buy and sell items to/from a shop.
Shop sells/buys items. You can also just add and remove Item from a shop selection of merchandise.

Do a shop simulator, where player can buy and sell different items from their inventory. You need to support selling all sorts of items: armour, chestpieces, weapons, armpieces...

#### Rules
##### Shop 
Sell- adds money to the shop. Shop can only sell items that it has. Selling item doesn't reduce item count in shop. Returns item sold.
Buy- removes money from shop. Shop cannot buy an item if it doesn't have enough money.
AddItem- shop can add extra items to the stock, but adding the same item twice has no effect.
RemoveItem- shop can remove items from stock by their name

##### Player
AddItem- adds item to players inventory. Can have multiple items of the same name.
RemoveItem0 removes item from players inventory. Does nothing if item is not found.

Note: you have initial structure and objects, but there is a lot of redundant and incomplete pieces. 
You need to fix that too. 

#### Extra task: Equipment
(no tests)  

Player also has equipment. Equipement has different slots for armor and for weapon. Player can equip and unequip different pieces of gear.
Sum of defense value of all equipment equals to total defense of player.
Attack value of weapon is player's total attack.
Player cannot have more items in their inventory than total weight allowed. The total max weight player has is determined by their strength status (30 + strength * 10 (kg)).

## Glossary
**Domain**- is the area of interest that you are working on. For example if you are building rockets, rocket science would be your domain.
Or if you are doing money related transaction processing, finances would be your domain.  

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