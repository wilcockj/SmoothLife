pal = input("input pallete thing: ")

splitted = pal.split(" [")
splitted = [x.replace("[","") for x in splitted]
splitted = [x.replace("]","") for x in splitted]
print("vec3 palettized = palette(t.r",end="")
for pal in splitted:
    colors = pal.split(" ")
    print(f",vec3({colors[0]},{colors[1]},{colors[2]})", end="")

print("\n")
