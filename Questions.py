##################################################### Basic Alteration Questions ##############################################
#Question: Resolving a ValueError in a try-except block:


try:
    num = int(input("Enter a number: "))
    print(num)
except ValueError:
    print("Invalid input")
print("Program ended")

#Answer:

while True:
    try:
        num = int(input("Enter a number: "))
        print(num)
        break
    except ValueError:
        print("Invalid input. Try again.")
print("Program ended")


    
################################################################################

#Question: Resolve the following code for logical error:


def is_leap_year(year):
    if year % 4 == 0:
        return True
    else:
        return False

print(is_leap_year(2000))

#Answer:

def is_leap_year(year):
    if year % 4 == 0 and (year % 400 == 0 or year % 100 != 0):
        return True
    else:
        return False

print(is_leap_year(2000))

################################################################################################

#Question: What's wrong with this code to calculate the average of a list of numbers?

numbers = [1, 2, 3, 4, 5]
sum = 0
for num in numbers:
    sum += num
avg = sum/len(numbers)
print("Average: " + avg)

########################################################################################################

#Question: Logical Error Question: What is the logical error in the following code?


def calculate_discount(price, discount_percent):
    discount = price * discount_percent / 100
    return price - discount

print(calculate_discount(100, "10"))
