"""Module for calculating the number of grains on the spaces of a chessboard.
"""

def square(number):
    """Function that returns the number of grains on a given square of a chessboard (between 1
    and 64).
    Will raise a ValueError exception if the given square is out of range of the chessboard.
    """
    if number < 1 or number > 64:
        raise ValueError("square must be between 1 and 64")

    return 1 << number - 1


def total():
    """Function that returns the number of grains on the entire chessboard.
    """
    return (1 << 64) - 1