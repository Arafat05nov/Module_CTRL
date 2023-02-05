##############################################Question###############################################

def divide(a, b):
    return a / b

num1 = 5
num2 = 0

try:
    result = divide(num1, num2)
    print("Result: ", result)
except ZeroDivisionError:
    print("Division by zero is not allowed.")

print("Program execution continues normally.")


###############################################Answer#############################################

def divide(a, b):
    if b == 0:
        return "Division by zero is not allowed."
    return a / b

num1 = 5
num2 = 0

result = divide(num1, num2)
print("Result: ", result)

print("Program execution continues normally.")
