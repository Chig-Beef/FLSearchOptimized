import random

def create_random_name():
    full = []
    amt = random.randint(1, 4)
    for j in range(amt):
        length = random.randint(3, 10)
        name = ""
        for i in range(length):
            name += chr(random.randint(65, 90))
        full.append(name)
    return (' ').join(full)

def create_random_price():
    return round(random.random()*150, 2)

def create_random_product():
    global gCode
    name = create_random_name()
    price = str(create_random_price())
    code = str(gCode)
    gCode += 1
    return (',').join((name, price, code))

gCode = 0
amt = 750000
products = []

for i in range(amt):
    products.append(create_random_product())

products = ('\n').join(products)

with open("productList.txt", "w") as file:
    file.write(products)

print("Finished")