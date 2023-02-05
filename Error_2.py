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
