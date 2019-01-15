<?php

/* anime/delete.html.twig */
class __TwigTemplate_1e1733241bfad738d1a99805024f86d77b5ec52595ba01b7d3ebefb62963d267 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "anime/delete.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_89c5a3404cf1d9c7a468baf1f5463f3e1051aca50fb6c4a54f8397dc67e0b54d = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_89c5a3404cf1d9c7a468baf1f5463f3e1051aca50fb6c4a54f8397dc67e0b54d->enter($__internal_89c5a3404cf1d9c7a468baf1f5463f3e1051aca50fb6c4a54f8397dc67e0b54d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "anime/delete.html.twig"));

        $__internal_fb15ca021dcf3259bf80faaa6c5d86d99e4d686d351dcbf55799fe67f6f3a77b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_fb15ca021dcf3259bf80faaa6c5d86d99e4d686d351dcbf55799fe67f6f3a77b->enter($__internal_fb15ca021dcf3259bf80faaa6c5d86d99e4d686d351dcbf55799fe67f6f3a77b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "anime/delete.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_89c5a3404cf1d9c7a468baf1f5463f3e1051aca50fb6c4a54f8397dc67e0b54d->leave($__internal_89c5a3404cf1d9c7a468baf1f5463f3e1051aca50fb6c4a54f8397dc67e0b54d_prof);

        
        $__internal_fb15ca021dcf3259bf80faaa6c5d86d99e4d686d351dcbf55799fe67f6f3a77b->leave($__internal_fb15ca021dcf3259bf80faaa6c5d86d99e4d686d351dcbf55799fe67f6f3a77b_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_4276de6933c6bf89b615e082ada4edce6578767eb0709881914937ff86260230 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_4276de6933c6bf89b615e082ada4edce6578767eb0709881914937ff86260230->enter($__internal_4276de6933c6bf89b615e082ada4edce6578767eb0709881914937ff86260230_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_b3baca3d6df5f5b099476696407567ca0d184d1127bc802928b0434ca52e75bc = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_b3baca3d6df5f5b099476696407567ca0d184d1127bc802928b0434ca52e75bc->enter($__internal_b3baca3d6df5f5b099476696407567ca0d184d1127bc802928b0434ca52e75bc_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "<h1>Delete Anime</h1>
<section>
    <form onsubmit=\"checkValue()\" method=\"POST\">
        <div>
            <label for=\"rating\">Rating</label>
            <input type=\"text\" id=\"rating\" value=\"";
        // line 9
        echo twig_escape_filter($this->env, $this->getAttribute(($context["anime"] ?? $this->getContext($context, "anime")), "rating", array()), "html", null, true);
        echo "\" name=\"anime[rating]\" disabled/>
            <label for=\"name\">Name</label>
            <input type=\"text\" id=\"name\" value=\"";
        // line 11
        echo twig_escape_filter($this->env, $this->getAttribute(($context["anime"] ?? $this->getContext($context, "anime")), "name", array()), "html", null, true);
        echo "\" name=\"anime[name]\" disabled/>
            <label for=\"description\">Description</label>
            <input type=\"text\" id=\"description\" value=\"";
        // line 13
        echo twig_escape_filter($this->env, $this->getAttribute(($context["anime"] ?? $this->getContext($context, "anime")), "description", array()), "html", null, true);
        echo "\" name=\"anime[description]\" disabled/>
            <label for=\"watched\">Watched</label>
            <input type=\"checkbox\" id=\"watched\" value=\"";
        // line 15
        echo twig_escape_filter($this->env, $this->getAttribute(($context["anime"] ?? $this->getContext($context, "anime")), "watched", array()), "html", null, true);
        echo "\" name=\"anime[watched]\" onclick=\"switchValue()\" disabled/>
            <label for=\"watched\" id=\"watched-label\"></label>

            ";
        // line 18
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "

            <button type=\"submit\" class=\"accept\">Delete</button>
            <button type=\"button\" class=\"cancel\" onclick=\"location.href='/'\">Cancel</button>
        </div>
    </form>
</section>

<script>
    function checkValue() {
        document.getElementById(\"watched\").checked = true;
        document.getElementById(\"rating\").disabled = false;
        document.getElementById(\"name\").disabled = false;
        document.getElementById(\"description\").disabled = false;
        document.getElementById(\"status\").disabled = false;
    }

    (function checkBox() {
        let checkbox = document.getElementById(\"watched\");
        checkbox.checked = checkbox.value !== \"not watched\";
    })();
</script>
";
        
        $__internal_b3baca3d6df5f5b099476696407567ca0d184d1127bc802928b0434ca52e75bc->leave($__internal_b3baca3d6df5f5b099476696407567ca0d184d1127bc802928b0434ca52e75bc_prof);

        
        $__internal_4276de6933c6bf89b615e082ada4edce6578767eb0709881914937ff86260230->leave($__internal_4276de6933c6bf89b615e082ada4edce6578767eb0709881914937ff86260230_prof);

    }

    public function getTemplateName()
    {
        return "anime/delete.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  77 => 18,  71 => 15,  66 => 13,  61 => 11,  56 => 9,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends \"base.html.twig\" %}

{% block main %}
<h1>Delete Anime</h1>
<section>
    <form onsubmit=\"checkValue()\" method=\"POST\">
        <div>
            <label for=\"rating\">Rating</label>
            <input type=\"text\" id=\"rating\" value=\"{{ anime.rating }}\" name=\"anime[rating]\" disabled/>
            <label for=\"name\">Name</label>
            <input type=\"text\" id=\"name\" value=\"{{ anime.name }}\" name=\"anime[name]\" disabled/>
            <label for=\"description\">Description</label>
            <input type=\"text\" id=\"description\" value=\"{{ anime.description }}\" name=\"anime[description]\" disabled/>
            <label for=\"watched\">Watched</label>
            <input type=\"checkbox\" id=\"watched\" value=\"{{ anime.watched }}\" name=\"anime[watched]\" onclick=\"switchValue()\" disabled/>
            <label for=\"watched\" id=\"watched-label\"></label>

            {{ form_row(form._token) }}

            <button type=\"submit\" class=\"accept\">Delete</button>
            <button type=\"button\" class=\"cancel\" onclick=\"location.href='/'\">Cancel</button>
        </div>
    </form>
</section>

<script>
    function checkValue() {
        document.getElementById(\"watched\").checked = true;
        document.getElementById(\"rating\").disabled = false;
        document.getElementById(\"name\").disabled = false;
        document.getElementById(\"description\").disabled = false;
        document.getElementById(\"status\").disabled = false;
    }

    (function checkBox() {
        let checkbox = document.getElementById(\"watched\");
        checkbox.checked = checkbox.value !== \"not watched\";
    })();
</script>
{% endblock %}", "anime/delete.html.twig", "D:\\PHP Solution\\app\\Resources\\views\\anime\\delete.html.twig");
    }
}
