
### Register
```js
POST {{host}}/auth/register
```

### Register Request
```json
{
	"firstName":"Rajib",
	"lastName":"Ahmed",
	"email":"saidul.is.rajib@gmail.com",
	"password":"Test@123"
}
```

### Register Response
```js
200 Ok
```

```json
{
	"id":"f47ac10b-58cc-4372-a567-0e02b2c3d479",
	"firstName":"Rajib",
	"lastName":"Ahmed",
	"email":"saidul.is.rajib@gmail.com",
	"token":"Test@123"
}
```

### Login Request
```js
POST {{host}}/auth/login
```

```json
{
	"email":"saidul.is.rajib@gmail.com",
	"password":"Test@123"
}
```

### Login Response

```json
{
	"id":"00000000-0000-0000-0000-000000000000",
	"firstName":"Rajib",
	"lastName":"Ahmed",
	"email":"saidul.is.rajib@gmail.com"
	"token":"esdfsdf.....sdfsf"
}
```
