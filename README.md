# C# .NET Framework projects

Welcome to this repository containing small projects written in C# using the .NET Framework. The projects are designed with interactive interfaces to communicate with the operator via the screen monitor, keyboard, and mouse.

Each project is briefly described below and is placed in its respective folder in the repository. In each folder, you can find documentation with detailed project descriptions in the Polish language.


## 1. Computer Game - Collecting Fruits by a Hedgehog
The computer game proceeds as follows:

1. The player can move the hedgehog right or left to collect falling fruits in the basket.
2. Fruit collection occurs when the "player" object touches the "fruit" object.
3. If a fruit falls to the ground, it turns into a stain.
4. Each collected fruit adds +1 point to the player's score, while each missed fruit deducts -1 point.
5. Fruits fall at a constant speed, and as the player's score increases, fruits generate and fall faster.
6. The player's movement speed is constant.
7. The player has three lives, and each missed fruit deducts 0.5 life.
8. The game ends when the player loses all lives.

<img src="https://github.com/lisajankk/C_sharp_small_projects/assets/124843836/36934fb5-7247-4f21-bece-e130559179aa" width="350">



## 2. Microprocessor Simulation Application
The processor model and application flow are as follows:

1. The processor has four 16-bit general-purpose registers labeled as AX, BX, CX, and DX.
2. Each register is treated as a pair of 8-bit registers denoted as NH for the higher part and NL for the lower part, where N represents A, B, C, or D.
3. The processor's instruction set includes three instructions: MOV (move), ADD (addition), and SUB (subtraction).
4. The processor supports two addressing modes: register mode and immediate mode.
5. The program allows writing short programs using the available instructions and addressing modes.
6. It provides options to execute programs in whole or step-by-step mode.
7. In step-by-step mode, the execution order of instructions is traced using line numbers in the program code.

The simulator program allows saving written programs to a file and then reloading them for further editing and re-execution.

<img src="https://github.com/lisajankk/C_sharp_small_projects/assets/124843836/f667d93b-aead-4686-8b27-6f929802e5fa" width="650">


## 3. RS232 Serial Transmission Simulation Application
Usage of this application involves the following steps:

1. In the **Wejście** (input) transmitter window, enter the text to be transmitted as an ASCII character string.
2. The entered text is formatted with a start bit (logical '1'), followed by the character bits from LSB to MSB, and two stop bits (logical '1', '1'), forming a binary string where each ASCII character has its own start and stop bits. Start bit and stop bits are colored red.
3. The binary string is displayed in a separate **Konwersja** (conversion) field on the monitor screen.
4. The string is transmitted to the receiver - the **Wyjście** (output) window, which is the second window of the same program.
5. In the receiver, the data string undergoes decoding, which involves removing frames and performing serial-to-parallel decomposition and converting the binary form to an ASCII character string.

Additionally, the application includes a "profanity filter." If any "profane" words from the dictionary are found in the transmitted text, they will be replaced with asterisks ('*').

<img src="https://github.com/lisajankk/C_sharp_small_projects/assets/124843836/fd07d106-021a-48f1-8ef8-891733fbf7be" width="650">



## 4. Calculator Application with Real-Time Clock
This application comprises the following features:

1. **Simple Calculator**: Performs basic arithmetic calculations.
2. **Real-Time Clock Display**: Shows the current time with the option to choose between an analog or digital clock.
3. **Calculator Skins**: Provides buttons to select different calculator skins:
    - Basic colors are available in the console, with the option to customize colors.
    - Option to load a downloaded image as the calculator's background.

Additionally, we have implemented the ability to input commands for the calculator using both the mouse and the keyboard.

<img src="https://github.com/lisajankk/C_sharp_small_projects/assets/124843836/85fba2b5-680b-4816-a7d3-ecbbaab42348" width="800">
