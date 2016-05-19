"use strict";

Object.defineProperty(exports, "__esModule", {
  value: true
});
exports.create = exports.createUnsafeTyped = exports.createUnsafeWith = exports.createTyped = exports.createWith = undefined;

var _Observable = require("FuseJS/Observable");

var _Observable2 = _interopRequireDefault(_Observable);

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

var createWith = exports.createWith = function (elem) {
  return (0, _Observable2.default)(elem);
};

var createTyped = exports.createTyped = function () {
  return (0, _Observable2.default)();
};

var createUnsafeWith = exports.createUnsafeWith = function (elem) {
  return (0, _Observable2.default)(elem);
};

var createUnsafeTyped = exports.createUnsafeTyped = function () {
  return (0, _Observable2.default)();
};

var create = exports.create = function () {
  return (0, _Observable2.default)();
};