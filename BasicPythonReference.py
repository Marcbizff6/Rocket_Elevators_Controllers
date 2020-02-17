txt = "Hello World"
txt = txt.replace("l","3")
print(txt)
txt = txt.replace("3","z")
print(txt)
txt = txt.replace("z","2")
print(txt)

age = 36
txt = "My name is John, and I am {}"
print(txt.format(age))

print(bool("abx"))

print(bool(0))

fruits1 = ["apple", "banana"]
if "apple" in fruits1:
 print("Yes, apple is a fruit!")
 print("Yes, apple is a fruit!")
 print("Yes, apple is a fruit!")
 print("Yes, apple is a fruit!")

print(fruits1[1])

fruits2 = ["apple", "banana", "cherry"]
print(fruits2[0])

fruits3 = ["apple", "banana", "cherry"]
fruits3[0] ="kiwi"
print(fruits3[0])
fruits3.append("orange")
fruits3.append("orange")
fruits3.append("orange")
print(fruits3)
fruits3.insert(1,"lemon")
print(fruits3)
fruits3.remove("banana")
print(fruits3)
fruits3.remove("orange")
print(fruits3)
fruits3.remove("orange")
print(fruits3)
print(fruits3[-2])

fruits4 = ["apple", "banana", "cherry", "orange", "kiwi", "melon", "mango"]
print(fruits4[2:5])
print(len(fruits4))

fruits5 = {"apple", "banana", "cherry"}
more_fruits5 = ["orange", "mango", "grapes"]
fruits5.update(more_fruits5)
print(fruits5)
fruits5.discard("banana")
print(fruits5)

car =	{
  "brand": "Ford",
  "model": "Mustang",
  "year": 1964
}
print(car.get("model"))
print(car.get("year"))
car["year"]=2020
print(car.get("year"))
print(car.get("color"))
car["color"] = "red"
print(car.get("color"))
print(car.get("model"))
car.pop("model")
print(car.get("model"))
car.clear()
print(car.get("brand"))
print(car.get("model"))
print(car.get("year"))
print(car.get("color"))

if 5 > 2: print("Five is greater than two!")

i = 1
while i < 6:
 print(i)
 i += 1

fruits6 = ["apple", "banana", "cherry"]
for x in fruits6:
 print(x)

fruits7 = ["apple", "banana", "cherry"]
for x in fruits7:
 if x == "banana":
  continue
  print(fruits7)

  
def my_function():
 print("Hello from a function")

my_function()

def my_function2(fname, lname):
 print(fname)

my_function2("Marc","Andre")

def my_function3(x):
 return x + 5

class MyClass: x = 5
p1 = MyClass()
print(p1.x)

