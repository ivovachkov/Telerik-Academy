var Slider = {
	init: function (container, images) {
		this.container = container;
		this.images = images;
	},
	initImages: function () {
		var containerElement = document.getElementById(this.container);
		var bigImgContainer = document.createElement("div");
		bigImgContainer.style.width = "500px";
		bigImgContainer.style.height = "300px";
		var bigImage = document.createElement("img");
		bigImage.src = this.images[0].bigUrl;
		bigImage.id = "big-img";
		bigImgContainer.appendChild(bigImage);

		containerElement.appendChild(bigImgContainer);

		for (var i = 0, len = this.images.length; i < len; i += 1) {
			var imageElement = bigImage.cloneNode(true);
			imageElement.title = this.images[i].title;
			imageElement.src = this.images[i].smallUrl;

			imageElement.addEventListener("click", function (ev) {
				bigImage.title = ev.target.title;
				bigImage.src = ev.target.src.replace("small", "big");
			}, false);

			containerElement.appendChild(imageElement);
		}
	},
	initLeftButton: function () {
		var self = this;
		var leftButton = Object.create(Button);
		leftButton.init("slider-btns", "left-btn");
		var leftButtonElement = document.createElement("input");
		leftButtonElement.type = "button";
		leftButtonElement.value = "Previous";
		leftButtonElement.id = leftButton.id;

		leftButtonElement.addEventListener("click", function () {
			var bigImage = document.getElementById("big-img");
			var imgSource = bigImage.src;
			for (var i = 0, len = self.images.length; i < len; i += 1) {
				var urlSource = self.images[i].bigUrl.substr(2);
				if (imgSource.lastIndexOf(urlSource) != -1) {
					if (i - 1 < 0) {
						i = len;
					}
					bigImage.src = self.images[i - 1].bigUrl;
					break;
				}
			}
		}, false);

		var buttonsContainer = document.getElementById(leftButton.container);
		buttonsContainer.appendChild(leftButtonElement);
	},
	initRightButton: function () {
		var self = this;
		var rightButton = Object.create(Button);
		rightButton.init("slider-btns", "right-btn");
		var rightButtonElement = document.createElement("input");
		rightButtonElement.type = "button";
		rightButtonElement.value = "Next";
		rightButtonElement.id = rightButton.id;

		rightButtonElement.addEventListener("click", function () {
			var bigImage = document.getElementById("big-img");
			var imgSource = bigImage.src;
			for (var i = 0, len = self.images.length; i < len; i += 1) {
				var urlSource = self.images[i].bigUrl.substr(2);
				if (imgSource.lastIndexOf(urlSource) != -1) {
					if (i + 1 >= len) {
						i = -1;
					}
					bigImage.src = self.images[i + 1].bigUrl;
					break;
				}
			}
		}, false);

		var buttonsContainer = document.getElementById(rightButton.container);
		buttonsContainer.appendChild(rightButtonElement);
	},
	initButtons: function () {
		this.initLeftButton();
		this.initRightButton();
	}
};

var Image = {
	init: function (title, smallUrl, bigUrl) {
		this.title = title;
		this.smallUrl = smallUrl;
		this.bigUrl = bigUrl;
	}
};

var Button = {
	init: function (container, id) {
		this.container = container;
		this.id = id;
	}
};