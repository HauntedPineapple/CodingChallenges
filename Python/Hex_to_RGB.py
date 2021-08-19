import os

outputFile = open("color-values.txt", "w")

# Hex color code is a 6 digits hexadecimal (base 16) number:
# RRGGBB
# The 2 left digits represent the red color
# The 2 middle digits represent the green color
# The 2 right digits represent the blue color
# Get the 2 left digits of the hex color code and convert to decimal value to get the red color level
# Get the 2 middle digits of the hex color code and convert to decimal value to get the green color level
# Get the 2 right digits of the hex color code and convert to decimal value to get the blue color level


def hex_to_RGB():
    inputFile = open("hex-values.txt")
    outputFile.write("Hex to RGB\n")

    for line in inputFile:
        r = line[0]+line[1]
        g = line[2]+line[3]
        b = line[4]+line[5]
        r = int(r, 16)
        g = int(g, 16)
        b = int(b, 16)

        output = "#"+line.upper() + " --> "
        output += "(" + str(r) + ", " + str(g) + ", " + str(b) + ")"
        outputFile.write(output+"\n")

    inputFile.close()

# Convert the red, green and blue color values from decimal to hex
# Concatenate the 3 hex values of the red, green and blue togather: RRGGBB


def RGB_to_hex():
    outputFile.write("RGB to Hex\n")
    inputFile = open("rgb-values.txt")

    for line in inputFile:
        values = line.split(", ")
        rr = int(values[0])
        gg = int(values[1])
        bb = int(values[2])

        r = hex(rr)
        g = hex(gg)
        b = hex(bb)

        r = str(r).split("x")[1]
        g = str(g).split("x")[1]
        b = str(b).split("x")[1]

        output = "("+str(rr)+", "+str(gg)+", "+str(bb)+") --> "
        output += "#"+r.upper()+g.upper()+b.upper()
        outputFile.write(output+"\n")

    inputFile.close()


def formatRGB(input):
    values = input.split(", ")
    r = values[0]
    g = values[1]
    b = values[2]

    return "("+r+", "+g+", "+b+")"


hex_to_RGB()
RGB_to_hex()

outputFile.close()
