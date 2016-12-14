# -*- coding: utf-8 -*-
from __future__ import unicode_literals

from django.db import models, migrations


class Migration(migrations.Migration):

    dependencies = [
    ]

    operations = [
        migrations.CreateModel(
            name='InsuranceInfo',
            fields=[
                ('insuranceNumber', models.AutoField(primary_key=True, serialize=False)),
                ('contractor', models.CharField(max_length=10)),
                ('insuredPerson', models.TextField()),
                ('admin', models.CharField(max_length=10)),
                ('SSNumber', models.CharField(max_length=16)),
                ('phoneNumber', models.CharField(max_length=14)),
                ('homeNumber', models.CharField(max_length=14)),
                ('address', models.TextField()),
                ('carKind', models.TextField()),
                ('carNumber', models.TextField()),
                ('insurancePeriod', models.CharField(max_length=9)),
                ('bunnapData', models.TextField()),
                ('bunnapPremium', models.TextField()),
                ('premium', models.TextField()),
                ('insuranceKind', models.TextField()),
                ('insuredPersonSSNumber', models.TextField()),
                ('memo', models.TextField()),
                ('profileImage', models.TextField(null=True)),
            ],
        ),
    ]
