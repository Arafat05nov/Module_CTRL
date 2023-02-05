###########################################Question############################################
#E
def factorial(n):
    result = 1
    for i in range(1, n + 1):
        result = result * i
    return result
#E
def choose(n, k):
    return factorial(n) / (factorial(k) * factorial(n - k))

n = int(input("Enter a value for n: "))
k = int(input("Enter a value for k: "))

result = choose(n, k)
print("Result: ", result)

################################################Answer####################################################

def factorial(n):
    result = 1
    for i in range(1, n + 1):
        result = result * i
    return int(result)

#This program calculates the number of combinations of k items that can be chosen from n items. 
#The bug in the program is that the result of factorial is being treated as a float even though it is an integer. This causes inaccuracies when calculating combinations.
