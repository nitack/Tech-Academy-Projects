from django.http import HttpResponse
from django.shortcuts import render

def home(request):
    products = ["Cherries", "Apples", "Oranges", "Strawberries", "Pears", "Watermellons"]
    context = {
        'products': products,
    }
    return render(request, "home.html", context)