LOC DataSegment
CatData      OCTA "Cats    "  # A data string to store "Cats"
CatCount     OCTA 0           # A data integer to store number of cats. Start at 0.

LOC Main
LDA $0, CatCount              # Load CatCount into register $0.
ADD $0, $0, 1                 # Add one to the cat count.
STO $0, CatCount              # Store the updated cat count back to memory.

SET $255, CatData             # Load the address of CatData into register $255.
TRAP 0, Halt, 0               # Halt the program.

Halt        TRAP 0, Halt, 0   # A redundant halt, because somehow you always miss one.

# End of the program
# dorktoast