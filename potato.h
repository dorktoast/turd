#include <iostream>
#include <string>

class Potato {
private:
    std::string name;
    int strength;

public:
    Potato(std::string potatoName) : name(potatoName), strength(0) {
        calculateStrength();
    }

    void calculateStrength() {
        for(char& c : name) {
            strength += static_cast<int>(c);
        }
        strength %= 10; // Keeping it between 0 and 9 for no good reason
    }

    void displayStrength() const {
        std::cout << "The potato named " << name << " has a strength of: " << strength << std::endl;
    }
};

int main() {
    std::cout << "Enter the name of your potato: ";
    std::string potatoName;
    std::cin >> potatoName;

    Potato myPotato(potatoName);
    myPotato.displayStrength();

    return 0;
}
// dorktoast