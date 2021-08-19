def readSchoty(abacus):
    """
    'abacus' is a list of 7 strings representing the abacus from top to bottom
    """
    unitFactor = 1
    value = 0
    count = 0

    i = 7
    while i > 0:
        i -= 1

        beads = abacus[i].split('-')

        for j in range(0, len(beads[0])):
            if beads[0][j] == "O":
                count += 1
                                
        value += count*unitFactor
        count = 0
        unitFactor *= 10

    return value
    # for (int i = 6; i > -1; i--)
    #         {
    #             string[] beads = abacus[i].Split('-')
    #             for (int a = 0; a < beads[0].Length; a++)
    #             {
    #                 if(beads[0][a]=='O')
    #                 {
    #                     count++
    #                 }
    #             }
    #             value += count * unitFactor
    #             count = 0
    #             unitFactor *= 10
    #         }
    #         return value
    pass


schoty_abacus = ["---OOOOOOOOOO",
                 "OOOOO---OOOOO",
                 "---OOOOOOOOOO",
                 "O---OOOOOOOOO",
                 "OO---OOOOOOOO",
                 "OOOOOO---OOOO",
                 "OOOO---OOOOOO"] # 501264
for row in schoty_abacus:
    print(row)
print("The value of the abacus is: ", readSchoty(schoty_abacus))

schoty_abacus = [ "---OOOOOOOOOO",
                  "---OOOOOOOOOO",
                  "---OOOOOOOOOO",
                  "OOO---OOOOOOO",
                  "O---OOOOOOOOO",
                  "OOOOOOOOO---O",
                  "OO---OOOOOOOO"] # 3192

for row in schoty_abacus:
    print(row)
print("The value of the abacus is: ", readSchoty(schoty_abacus))
