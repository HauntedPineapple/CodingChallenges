import math


def testIsTriangleWord():
    words = ["ABILITY", "BECOME", "CHECK", "CHILD",
             "GROWING", "ISSUE", "NECESSARILY", "OURSELVES",
             "PERFORM", "PROPERTY", "QUALITY", "REDUCTION", "SKY", "SOUTHERN"]

    for word in words:
        if isTriangleWord(word):
            print(word, "IS a triangle word")
        else:
            print(word, "is NOT a triangle word")


def testFile():
    file = open("p042_words.txt")
    allWords = file.read().split(",")
    numTriWords = 0

    for word in allWords:
        if isTriangleWord(word):
            numTriWords += 1
            #print(word, "IS a triangle word")

    print(numTriWords, "out of", len(allWords), "are triangle words")


def isTriangleWord(word):
    if not word.isalpha():
        return False

    Alphabet = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l",
                "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"]
    alphabetValues = {}
    for i in range(len(Alphabet)):
        alphabetValues[Alphabet[i]] = i+1

    word = word.lower()
    total = 0
    for letter in word:
        for key, value in alphabetValues.items():
            if letter == key:
                total += value
    total *= 2
    total = -total
    # A triangle number is defined as t(n) = 1/2*n(n+1)
    # We will use this knowledge to determine if the total is
    # a triangle word. If the total is a triangle number, that means
    # the word is a triangle word.
    # We will use the quadratic equation with a and b being 1, and
    # the total will be represented by c, the constant
    # If we get a whole number back, the word is a triangle word

    # If the discriminant (b2−4ac) is negative,
    # there are two complex solutions so return "false"
    if (math.sqrt(1 - 4 * 1 * total) < 0):
        return False

    # Quadratic equation: (-b+√(b^2-4ac))/2a
    root = -1 + math.sqrt(1 - 4 * 1 * total)
    root = root / 2
    if root % 2 == 0 or root % 2 == 1:
        return True
    else:
        return False


testIsTriangleWord()
testFile()