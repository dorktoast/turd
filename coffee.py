class Coffee:
    def __init__(self):
        self.hot = True
        self.tasty = True

class Developer:
    def __init__(self):
        self.awake = False

    def drink(self, beverage):
        if isinstance(beverage, Coffee):
            self.code()
        else:
            raise ValueError("This isn't coffee!")

    def code(self):
        try:
            for _ in range(9999):
                # Try to write quality code
                quality = "low"
        except:
            # Oops, coffee spill
            return "Need more coffee!"

    def think(self):
        thoughts = ["Why is this code like this?", "Who wrote this?", "Was it me?", "Probably."]
        return thoughts

dev = Developer()
print(dev.think())
try:
    dev.drink("water")
except ValueError as e:
    print(e)

coffee = Coffee()
print(dev.drink(coffee))

# dorktoast