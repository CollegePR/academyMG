from django.db import models

# Create your models here.
class InsuranceInfo(models.Model):
    insuranceNumber=models.AutoField(primary_key=True)
    contractor=models.CharField(max_length=10)
    insuredPerson=models.TextField()
    admin=models.CharField(max_length=10)
    SSNumber=models.CharField(max_length=16)
    phoneNumber=models.CharField(max_length=14)
    homeNumber=models.CharField(max_length=14)
    address=models.TextField()
    carKind=models.TextField()
    carNumber=models.TextField()
    insurancePeriod=models.CharField(max_length=9)
    bunnapData=models.TextField()
    bunnapPremium=models.TextField()
    premium=models.TextField()
    insuranceKind=models.TextField()
    insuredPersonSSNumber=models.TextField()
    memo=models.TextField()
    profileImage=models.TextField(null=True)
    def __str__(self):              # __unicode__ on Python 2
        return self.name
