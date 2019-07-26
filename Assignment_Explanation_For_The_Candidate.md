# Assignment 1

## Objective
Using the current skeleton, the program will return the validation result of a certain string passed in the POST method of the controller.

## Sample call

```
curl -XPOST -d "aaa,bbb,cc..." http://localhost:5000/api/EntityValidation
```

## Requirements

1. The record is posted as a string to a listening controller.
2. The record needs to be validated in various ways.
3. The record is a __comma separated__ list of values that match the _Domain.Entity_
  - the fields of the CSV string should be in the same order as the members of the class
  - the number of fields must match the number of properties of the entity.


## Validations

There will be two validation categories:
  1. Validate that the record can be PARSED
  2. Validation of the record's data


### Parse validation
Whitespace is OK as long as the 'field' can be parsed
```
This is a VALID (parsable record)    "Tom,2,4 ,Add, 0,Nok,BlahBlah"
      User=Tom
      Operand1=2,
      Operand2=4,
      Operator=Sum,
      OperationResult=8457,
      OperationMessage="Nok",
      RandomMessage="BlahBlah"

This one also: "dick@example.com,2,6,Multiply ,12,ok,BlahBlah"

However, this is invalid "Harry,1,6,----,-5,ok,BlahBlah" as the operand cannot be parsed.

```

### Data validation

Here we want to apply multiple validation rules.

* All strings have at least one character.
* The Result of the operation is OK.
  * Eg. Operand1=1, Operand2=1, Operator=Substract, OperationResult=0
  * However, this is NOK ==>  Operand1=1, Operand2=1, Operator=Substract, OperationResult=-111


## Expected result

* The post method should return a list of results.
* For each of those results, we'd like to see the name of the validator, the result of the validation and eventualy the cause of validation failure.
* The message may be an exception message


Sample results:
```
[
  "validation": {
    "name": "Parse"
    "status": "Failed",
    "reason": "Operand is not present"
  }
]
```
or

```
[
  "validation": {
    "name": "Parse"
    "status": "Passed"
  },
  "validation": {
    "name": "Operation"
    "status": "Failed",
    "reason": "1 Add 2 is not 8"
  },
  "validation": {
    "name": "StringLength"
    "status": "Passed"
  },
  ....
]
```

## Hints

1. The focus is __"future" extensibility__.

2. The ParseService is just very naive example, but __is not the focus of the assignment__. Feel free to imporve it ONCE you have done the other tasks.

3. You do not need to use the same classes; you can delete, create new ones or modify what there is.

4. You may use ANY third-party NuGet package