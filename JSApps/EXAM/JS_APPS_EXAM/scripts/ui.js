define([], function () {

    var ui = (function () {

        function initialUI() {
            var html =  '<label>Messages from User:</label><input type="text" id="filter-by-user" /><br /><label>Messages with content:</label><input type="text" id="filter-by-pattern" /><br /><span>Sort By</span><select id="sortby-select"><option value="title">Title</option><option value="postDate">Date</option></select><div><span>*The sorting will be Ascending. Check the box if you want Descending</span><input type="checkbox" id="is-descending" value="Descending"/></div><br /><button id="btn-get-messages">Get messages</button><div id="additional-user-actions"></div><div id="returned-messages"></div>'
            return html;
        }

        function buildLoginRegister() {
            var html = '<p><a href="#/login">LOGIN</a></p><p>OR</p><p><a href="#/register">REGISTER</a></p>'
            return html;
        }

        function buildSendMsgForm() {
            var html = '<input type="text" id="user-message-title" placeholder="Title" /><input type="text" id="user-message-body" placeholder="Type your message..." /><button id="btn-send-message">Send Message</button><button id="btn-logout">Log Out</button>'
            return html;

        }

        function buildLoginForm() {
            var html = '<h3>Login form</h3><label>Username:</label><input type="text" id="tb-username" /><br /><label>Password:</label><input type="password" id="tb-password" /><br /><button id="btn-login">Login</button>';
            return html;
        }

        function buildRegisterForm() {
            var html = '<h3>Register form</h3><label>Username:</label><input type="text" id="tb-username" /><br /><label>Password:</label><input type="password" id="tb-password" /><br /><button id="btn-register">Register</button>';
            return html;
        }


        return {
            initial: initialUI,
            loginRegisterUI: buildLoginRegister,
            sendMsgForm: buildSendMsgForm,
            loginForm: buildLoginForm,
            registerForm: buildRegisterForm
        }
    }());

    return ui;
})