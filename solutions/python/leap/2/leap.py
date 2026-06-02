"""
Module for determining whether or not years are leap years.
"""

def leap_year(year):
    """Function that determines whether the year provided as a parameter is a leap year or not.
    """
    return (year % 4 == 0 and year % 100 != 0) or year % 400 == 0
