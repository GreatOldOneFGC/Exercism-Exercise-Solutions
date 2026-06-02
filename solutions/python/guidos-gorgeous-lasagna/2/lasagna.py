"""Functions used in preparing Guido's gorgeous lasagna.

Learn about Guido, the creator of the Python language:
https://en.wikipedia.org/wiki/Guido_van_Rossum

This is a module docstring, used to describe the functionality
of a module and its functions and/or classes.
"""


EXPECTED_BAKE_TIME = 40
PREPARATION_TIME = 2


def bake_time_remaining(elapsed_bake_time: int) -> int:
    """Calculate the bake time remaining.

    :param elapsed_bake_time (int): The baking time already elapsed.

    :return: int: The remaining bake time (in minutes) derived from 'EXPECTED_BAKE_TIME'.

    Function that takes the actual minutes the lasagna has been in the oven as
    an argument and returns how many minutes the lasagna still needs to bake
    based on the `EXPECTED_BAKE_TIME`.
    """

    return EXPECTED_BAKE_TIME - elapsed_bake_time


def preparation_time_in_minutes(number_of_layers: int) -> int:
    """Calculate the preparation time.

    :param number_of_layers (int): The number of layers in the lasagna.

    :return: int: The time (in minutes) it will take to prepare the lasagna derived from 'PREPARATION_TIME'.

    Function that takes in the number of layers the lasagna will have as an
    argument and returns how many minutes the lasagna will take to prepare based
    on the `PREPARATION_TIME`.
    """

    return number_of_layers * PREPARATION_TIME

def elapsed_time_in_minutes(number_of_layers: int, elapsed_bake_time: int) -> int:
    """Definition.

    :param number_of_layers (int): The number of layers in the lasagna.
    :param elapsed_bake_time (int): The baking time already elapsed.

    :return: int: The amount of time that has elapsed (in minutes) derived from 'preparation_time_in_minutes()'

    Function that takes in the numbers of layers the lasagna has and the actual minutes
    the lasagna has been in the oven as arguments and returns how many minutes have elapsed
    since preparation began.
    """

    return preparation_time_in_minutes(number_of_layers) + elapsed_bake_time
