<?php

/* :film:delete.html.twig */
class __TwigTemplate_13548360a8da74f8579af005e65aeef9b6596bc07573c70f5c89d9f6d180ce11 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", ":film:delete.html.twig", 1);
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
        $__internal_7e948e5b887c1187d08e3d822a21646b172f6cde6e21bd60c46719170a14a2b2 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_7e948e5b887c1187d08e3d822a21646b172f6cde6e21bd60c46719170a14a2b2->enter($__internal_7e948e5b887c1187d08e3d822a21646b172f6cde6e21bd60c46719170a14a2b2_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":film:delete.html.twig"));

        $__internal_5a1e0e981c85bf17b4d0730105e483081c0deeda046ed665eae723313b48444e = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_5a1e0e981c85bf17b4d0730105e483081c0deeda046ed665eae723313b48444e->enter($__internal_5a1e0e981c85bf17b4d0730105e483081c0deeda046ed665eae723313b48444e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":film:delete.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_7e948e5b887c1187d08e3d822a21646b172f6cde6e21bd60c46719170a14a2b2->leave($__internal_7e948e5b887c1187d08e3d822a21646b172f6cde6e21bd60c46719170a14a2b2_prof);

        
        $__internal_5a1e0e981c85bf17b4d0730105e483081c0deeda046ed665eae723313b48444e->leave($__internal_5a1e0e981c85bf17b4d0730105e483081c0deeda046ed665eae723313b48444e_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_ae9b85de5482badbd61fad8dca68cf5ffc862667c2be5264333fbf58c2552275 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_ae9b85de5482badbd61fad8dca68cf5ffc862667c2be5264333fbf58c2552275->enter($__internal_ae9b85de5482badbd61fad8dca68cf5ffc862667c2be5264333fbf58c2552275_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_cb5485f072a7c64afb1f71c61861da023844bbbac1fd2349b51bf1d62c2c1239 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_cb5485f072a7c64afb1f71c61861da023844bbbac1fd2349b51bf1d62c2c1239->enter($__internal_cb5485f072a7c64afb1f71c61861da023844bbbac1fd2349b51bf1d62c2c1239_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "    <h1>Delete Film</h1>
    <section>
        <form method=\"POST\">
            <div>
                <label for=\"name\">Name</label>
                <input type=\"text\" id=\"name\" value=\"";
        // line 9
        echo twig_escape_filter($this->env, $this->getAttribute(($context["film"] ?? $this->getContext($context, "film")), "name", array()), "html", null, true);
        echo "\" name=\"film[name]\" disabled />
                <label for=\"genre\">Genre</label>
                <input type=\"text\" id=\"genre\" value=\"";
        // line 11
        echo twig_escape_filter($this->env, $this->getAttribute(($context["film"] ?? $this->getContext($context, "film")), "genre", array()), "html", null, true);
        echo "\" name=\"film[genre]\" disabled />
                <label for=\"director\">Director</label>
                <input type=\"text\" id=\"director\" value=\"";
        // line 13
        echo twig_escape_filter($this->env, $this->getAttribute(($context["film"] ?? $this->getContext($context, "film")), "director", array()), "html", null, true);
        echo "\" name=\"film[director]\" disabled />
                <label for=\"year\">Year</label>
                <input type=\"text\" id=\"year\" value=\"";
        // line 15
        echo twig_escape_filter($this->env, $this->getAttribute(($context["film"] ?? $this->getContext($context, "film")), "year", array()), "html", null, true);
        echo "\" name=\"film[year]\" disabled />

                ";
        // line 17
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "

                <button type=\"submit\" class=\"accept\">Delete</button>
                <button type=\"button\" onclick=\"location.href='/'\" class=\"cancel\">Cancel</button>
            </div>
        </form>
    </section>
";
        
        $__internal_cb5485f072a7c64afb1f71c61861da023844bbbac1fd2349b51bf1d62c2c1239->leave($__internal_cb5485f072a7c64afb1f71c61861da023844bbbac1fd2349b51bf1d62c2c1239_prof);

        
        $__internal_ae9b85de5482badbd61fad8dca68cf5ffc862667c2be5264333fbf58c2552275->leave($__internal_ae9b85de5482badbd61fad8dca68cf5ffc862667c2be5264333fbf58c2552275_prof);

    }

    public function getTemplateName()
    {
        return ":film:delete.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  76 => 17,  71 => 15,  66 => 13,  61 => 11,  56 => 9,  49 => 4,  40 => 3,  11 => 1,);
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
    <h1>Delete Film</h1>
    <section>
        <form method=\"POST\">
            <div>
                <label for=\"name\">Name</label>
                <input type=\"text\" id=\"name\" value=\"{{ film.name }}\" name=\"film[name]\" disabled />
                <label for=\"genre\">Genre</label>
                <input type=\"text\" id=\"genre\" value=\"{{ film.genre }}\" name=\"film[genre]\" disabled />
                <label for=\"director\">Director</label>
                <input type=\"text\" id=\"director\" value=\"{{ film.director }}\" name=\"film[director]\" disabled />
                <label for=\"year\">Year</label>
                <input type=\"text\" id=\"year\" value=\"{{ film.year }}\" name=\"film[year]\" disabled />

                {{ form_row(form._token) }}

                <button type=\"submit\" class=\"accept\">Delete</button>
                <button type=\"button\" onclick=\"location.href='/'\" class=\"cancel\">Cancel</button>
            </div>
        </form>
    </section>
{% endblock %}", ":film:delete.html.twig", "D:\\PHP Skeleton\\app/Resources\\views/film/delete.html.twig");
    }
}
