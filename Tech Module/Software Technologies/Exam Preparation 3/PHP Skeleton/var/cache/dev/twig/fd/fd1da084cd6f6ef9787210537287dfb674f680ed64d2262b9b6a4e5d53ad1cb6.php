<?php

/* :film:create.html.twig */
class __TwigTemplate_56092d9c4f1e2a11bc6b385f9b00041380cf8ea029a2d93881e5652fcc0b5d2c extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", ":film:create.html.twig", 1);
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
        $__internal_8add3a016541355c492de2770735a3be30d2f3c43eb2061bcad3cd5e701273f7 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_8add3a016541355c492de2770735a3be30d2f3c43eb2061bcad3cd5e701273f7->enter($__internal_8add3a016541355c492de2770735a3be30d2f3c43eb2061bcad3cd5e701273f7_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":film:create.html.twig"));

        $__internal_cd07211c4e5941abf899eb2d34d042388f52312452ee39c37939dbba59a19882 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_cd07211c4e5941abf899eb2d34d042388f52312452ee39c37939dbba59a19882->enter($__internal_cd07211c4e5941abf899eb2d34d042388f52312452ee39c37939dbba59a19882_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":film:create.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_8add3a016541355c492de2770735a3be30d2f3c43eb2061bcad3cd5e701273f7->leave($__internal_8add3a016541355c492de2770735a3be30d2f3c43eb2061bcad3cd5e701273f7_prof);

        
        $__internal_cd07211c4e5941abf899eb2d34d042388f52312452ee39c37939dbba59a19882->leave($__internal_cd07211c4e5941abf899eb2d34d042388f52312452ee39c37939dbba59a19882_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_21c42210b60a93cd079894fd705e93b6761019ee1b992aa8dcce868dd993914c = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_21c42210b60a93cd079894fd705e93b6761019ee1b992aa8dcce868dd993914c->enter($__internal_21c42210b60a93cd079894fd705e93b6761019ee1b992aa8dcce868dd993914c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_01614dac10707ff9e60d7e225123b4000fa603f212b962b54d03a0af76abd9e6 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_01614dac10707ff9e60d7e225123b4000fa603f212b962b54d03a0af76abd9e6->enter($__internal_01614dac10707ff9e60d7e225123b4000fa603f212b962b54d03a0af76abd9e6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "<h1>Create Film</h1>
<section>
    <form method=\"POST\">
        <div>
            <label for=\"name\">Name</label>
            <input type=\"text\" id=\"name\" name=\"film[name]\" />
            <label for=\"genre\">Genre</label>
            <input type=\"text\" id=\"genre\" name=\"film[genre]\" />
            <label for=\"director\">Director</label>
            <input type=\"text\" id=\"director\" name=\"film[director]\" />
            <label for=\"year\">Year</label>
            <input type=\"text\" id=\"year\" name=\"film[year]\" />

            ";
        // line 17
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "

            <button type=\"submit\" class=\"accept\">Create</button>
            <button type=\"button\" onclick=\"location.href='/'\" class=\"cancel\">Cancel</button>
        </div>
    </form>
</section>
";
        
        $__internal_01614dac10707ff9e60d7e225123b4000fa603f212b962b54d03a0af76abd9e6->leave($__internal_01614dac10707ff9e60d7e225123b4000fa603f212b962b54d03a0af76abd9e6_prof);

        
        $__internal_21c42210b60a93cd079894fd705e93b6761019ee1b992aa8dcce868dd993914c->leave($__internal_21c42210b60a93cd079894fd705e93b6761019ee1b992aa8dcce868dd993914c_prof);

    }

    public function getTemplateName()
    {
        return ":film:create.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  64 => 17,  49 => 4,  40 => 3,  11 => 1,);
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
<h1>Create Film</h1>
<section>
    <form method=\"POST\">
        <div>
            <label for=\"name\">Name</label>
            <input type=\"text\" id=\"name\" name=\"film[name]\" />
            <label for=\"genre\">Genre</label>
            <input type=\"text\" id=\"genre\" name=\"film[genre]\" />
            <label for=\"director\">Director</label>
            <input type=\"text\" id=\"director\" name=\"film[director]\" />
            <label for=\"year\">Year</label>
            <input type=\"text\" id=\"year\" name=\"film[year]\" />

            {{ form_row(form._token) }}

            <button type=\"submit\" class=\"accept\">Create</button>
            <button type=\"button\" onclick=\"location.href='/'\" class=\"cancel\">Cancel</button>
        </div>
    </form>
</section>
{% endblock %}", ":film:create.html.twig", "D:\\PHP Skeleton\\app/Resources\\views/film/create.html.twig");
    }
}
