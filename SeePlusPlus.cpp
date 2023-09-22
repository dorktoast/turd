#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

class ConfusedConstructor {
    public:
        ConfusedConstructor() {
            cout << "Constructing or deconstructing?" << endl;
        }
        ~ConfusedConstructor() {
            cout << "Desconstructed!" << endl;
        }
};

class PointlessPointer {
private: 
    int value;
    int* pointerToValue;
    vector<int*> pointerContainer;

public:
    PointlessPointer(int v) : value(v) {
        pointerToValue = &value;
        pointerContainer.push_back(pointerToValue);
    }

// why

    void scramblePointer() {
        for (size_t i = 0; i < 1000; ++i) {
            int* tmpPointer = new int;
            pointerContainer.push_back(tmpPointer);
        }
        random_shuffle(pointerContainer.begin(), pointerContainer.end());
    }

// please

    int getPointerValue() {
        for (auto ptr : pointerContainer) {
            if (ptr == pointerToValue) {
                return *ptr;
            }
        }
        throw "oops";
    }

// stahp

    ~PointlessPointer() {
        for (auto ptr : pointerContainer) {
            if (ptr != pointerToValue) {
                delete ptr;
            }
        }
    }
};

// dorktoast