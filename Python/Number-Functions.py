import math

def isPrime():
    pass

def interprime(num):
    pass

def expandedForm(num):
    pass

def moranOrHarshad(num):
    pass

def nthFibonacci(n):
    ''' Recursive method (inefficient)
    if n < 0:
        print("Invalid input")
    elif n==0:
        return 0
    elif n==1:
        return 1
    else:
        return nthFibonacci(n-1)+nthFibonacci(n-2)
    '''
    
    #Fn = {[(√5 + 1)/2] ^ n} / √5 
    phi = (1 + math.sqrt(5)) / 2
    return round(pow(phi, n) / math.sqrt(5))


def testPrime():
    print("Prime Numbers:")
    primeNums = []
    count = 0
    number = 0
    while count < 50:
        if(isPrime(number)):
            primeNums.append(number)
            count+=1
        number+=1
    print("The first 30 prime numbers are:", primeNums)
testPrime()

def testInterprime():
    print("Interprime Numbers:")
    input = [6,9,13,44]
testInterprime()

def testExpandedForm():
    print("Expanded Numbers:")
    input = [25,70701,685,1037903,802539]
testExpandedForm()

def testMoranHarshad():
    print("Moran and Harshad Numbers:")
    input = [132,133,134]
testMoranHarshad()

def testFibonacci():
    print("Fibonacci Numbers:")
    print("The first 25 fibonacci numbers are:")
    for i in range(25):
        print(nthFibonacci(i))
testFibonacci()