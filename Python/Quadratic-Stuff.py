import math

print("A quadratic equation can be represented by the coefficients \"a\", \"b\" and \"c\"")
print("\"a\" is the coefficient of x^2")
print("\"b\" is the coefficient of x")
print("\"c\" is the constant term")
print("And can be written in standard form as f(x) = ax^2 + bx + c")
print("It can also be expressed in vertex form: f(x) = a(x+h)^2 + k")
print("where the vertex is (-h, k)")


def findQuadraticVertex(a, b, c):
    h = b / 2 * a
    k = c - (math.pow(b, 2) / 4 * a)

    return [-h, k]

def testQuadraticVertex():
    print("Vertex Finder:")
    a = [1, -1, 1]
    b = [0, 0, 10]
    c = [25, 25, 4]
    for i in range(3):
        solution = findQuadraticVertex(a[i],b[i],c[i])
        print("The quadratic equation with coefficients a =",a[i],"b =",b[i],"c =", c[i])
        print("has a vertex at ("+str(solution[0])+", "+str(solution[1])+")")
testQuadraticVertex()

