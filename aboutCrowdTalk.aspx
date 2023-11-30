<%@ Page Language="C#" AutoEventWireup="true" CodeFile="aboutCrowdTalk.aspx.cs" Inherits="aboutCrowdTalk" %>

<!DOCTYPE html>

<!DOCTYPE HTML>
<html>
<head>
    <title>CrowdTalk - About</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, user-scalable=no" />
    <link rel="stylesheet" href="assets/css/main.css" />
    <style>
        /* Add your custom styles here */
    </style>
</head>
<body class="is-preload">

    <form id="form1" runat="server">

        <!-- Wrapper -->
        <div id="wrapper">

            <!-- Header -->
            <header id="header">
                <h1><a href="CrowdTalk.aspx">CrowdTalk</a></h1>
                <nav class="links">
                    <ul>
                        <li><a href="CrowdTalk.aspx">Home</a></li>
                        <li><a href="Trending.aspx">Trending</a></li>
                        <li><a href="CreatePost.aspx">Create Post</a></li>
                        <li><a href="CreateCommunity.aspx">Create Community</a></li>
                    </ul>
                </nav>
                <nav class="main">
                    <ul>
                        <li class="search">
                            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                        </li>
                        <li class="menu">
                            <a class="fa-bars" href="#menu">Menu</a>
                        </li>
                    </ul>
                </nav>
            </header>

            <!-- Menu -->
            <section id="menu">

                <!-- Search -->
                <section>
                    <input type="text" name="query" placeholder="Search" />
                </section>

                <!-- Links -->
                <section>
                    <ul class="links">
                        <li>
                            <a href="MyPosts.aspx">
                                <h3>My Posts</h3>
                                <p>View how My Posts looks!</p>
                            </a>
                        </li>
                        <li>
                            <a href="MyPosts.aspx">
                                <h3>Edit Profile</h3>
                                <p>View/Edit how your Profile looks!</p>
                            </a>
                        </li>
                        <li>
                            <a href="ManageCommunities.aspx">
                                <h3>Communities</h3>
                                <p>Manage/Moderate the communities!</p>
                            </a>
                        </li>
                        <li>
                            <a href="#">
                                <h3>Terms and Policies.</h3>
                                <p>View the content policy and user agreement for CrowdTalk.</p>
                            </a>
                        </li>
                        <li>
                            <a href="#">
                                <h3>User Settings</h3>
                                <p></p>
                            </a>
                        </li>
                    </ul>
                </section>

                <!-- Actions -->
                <section>
                    <ul class="actions stacked">
                        <li><a href="Login.aspx" class="button large fit">Log out</a></li>
                    </ul>
                </section>

            </section>

            <!-- Main -->
            <div id="main">

                <!-- About Section -->
                <section id="about" class="wrapper">
                    <div class="inner">
                        <h2>About CrowdTalk</h2>
                        <p>CrowdTalk is a social network designed to provide users with a seamless and enjoyable user experience. Our platform focuses on delivering a fluent UI-based interface that encourages users to connect, share, and engage with others in meaningful discussions and interactions.</p>
                        <p>At CrowdTalk, we believe in fostering a community-driven environment where users can freely express their thoughts, ideas, and interests. Whether you're passionate about technology, sports, art, or any other topic, CrowdTalk offers a diverse range of communities and discussions to explore.</p>
                        <p>Key Features:</p>
                        <ul>
                            <li>Fluent UI-based social network</li>
                            <li>User-friendly interface for seamless navigation</li>
                            <li>Community-driven discussions on various topics</li>
                            <li>Easy post creation and sharing</li>
                            <li>Engagement through upvotes and comments</li>
                            <li>Trending posts and popular communities</li>
                        </ul>
                      <br />
                    </div>
                </section>

                <!-- Additional Information Section -->
                <section id="additional-info" class="wrapper">
                    <div class="inner">
                        <h2>Why Choose CrowdTalk?</h2>
                        <p>CrowdTalk stands out from other social networks due to its unique features and focus on user experience. Here's why you should choose CrowdTalk:</p>
                        <ul>
                            <li>User-Centered Design: CrowdTalk puts users at the center of its design philosophy. We prioritize creating an intuitive and user-friendly interface that ensures a seamless and enjoyable experience for all users.</li>
                            <li>Diverse Communities: With CrowdTalk, you'll find a wide range of communities covering various interests and topics. Whether you're into technology, gaming, arts, or any other passion, there's a community for you to join and engage with like-minded individuals.</li>
                            <li>Engaging Discussions: Our platform encourages meaningful discussions and interactions among users. You can participate in conversations, share your thoughts, and gain insights from others. CrowdTalk fosters a vibrant and inclusive environment for exchanging ideas.</li>
                            <li>Easy Post Creation: Creating and sharing posts on CrowdTalk is a breeze. You can effortlessly express yourself by sharing text, images, videos, and links. Engage with the community through your posts and receive feedback and appreciation.</li>
                            <li>Community Moderation: CrowdTalk empowers community moderators to ensure a safe and respectful environment. Our moderation tools enable communities to maintain high-quality discussions and address any issues that may arise.</li>
                            <li>Trending Content: Stay up-to-date with the latest trends and popular discussions on CrowdTalk. Our algorithm highlights trending posts and communities, making it easy for you to discover engaging content.</li>
                            <li>Responsive Support: We value your feedback and strive to provide excellent support. Our dedicated team is readily available to assist you with any questions or concerns you may have.</li>
                        </ul>
                        <p>Join CrowdTalk today and become part of a vibrant community that values connection, collaboration, and meaningful conversations. Experience a social network designed with you in mind, where your voice matters.</p>
                    </div>
                </section>

            </div>

        </div>

        <!-- Scripts -->
        <script src="assets/js/jquery.min.js"></script>
        <script src="assets/js/browser.min.js"></script>
        <script src="assets/js/breakpoints.min.js"></script>
        <script src="assets/js/util.js"></script>
        <script src="assets/js/main.js"></script>

    </form>

</body>
</html>
