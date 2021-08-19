def countUnique(str_1, str_2):
    '''Counts the number of unique characters that appear in both strings'''
    word = (str_1 + str_2).lower()
    characters = []

    for letter in word:
        if not characters.__contains__(letter):
            characters.append(letter)
    return len(characters)


def isPalindrome(word):
    if len(word) == 1:
        return True

    for i in range(0, len(word)//2):
        if word[i] != word[len(word)-i-1]:
            return False

    return True


def reverseString(word):
    '''Recursively reverses the given string'''
    if len(word) > 0:
        return word[len(word)-1]+reverseString(word[0:len(word)-1])
    else:
        return word

    # Note: There is an easy way to do this with one line of code
    # word = word[::-1]



def stringCycler(str_1, str_2):
    '''Given two strings, repeatedly cycles through all of the letters in the first string until it is the 
    same length as the second string, then returns that cycled string'''
    result = ""
    count = 0
    while count < len(str_2):
        for i in range(0, len(str_1)):
            if count == len(str_2):
                break
            result = result+str_1[i]
            count += 1
    return result


def testFunctions():
    print("countUnique(\"apple\",\"play\" -->", countUnique("apple", "play"))
    print("countUnique(\"sore\",\"zebra\") -->", countUnique("sore", "zebra"))

    print("isPalindrome(\"minimum\") -->", isPalindrome("minimum"))
    print("isPalindrome(\"tacocat\") -->", isPalindrome("tacocat"))
    print("isPalindrome(\"different\") -->", isPalindrome("different"))

    print("stringCycler(\"abc\", \"hello\") -->", stringCycler("abc", "hello"))
    print("stringCycler(\"programming\", \"edabit\") -->",
          stringCycler("programming", "edabit"))

    print("reverseString(\"Vertex\") -->", reverseString("Vertex"))
    print("reverseString(\"racecar\") -->", reverseString("racecar"))
    print("reverseString(\"triangle\") -->", reverseString("triangle"))


testFunctions()
